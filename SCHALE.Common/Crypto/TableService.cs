using Google.FlatBuffers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SCHALE.Common.Crypto.XXHash;
using SCHALE.Common.FlatData;
using System.Reflection;
using System.Text;

namespace SCHALE.Common.Crypto
{
    public static class TableService
    {
        /// <summary>
        /// General password gen by file name, encode to base64 for zips password
        /// </summary>
        /// <param name="key"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] CreatePassword(string key, int length = 20)
        {
            byte[] password = GC.AllocateUninitializedArray<byte>((int)Math.Round((decimal)(length / 4 * 3)));

            using var xxhash = XXHash32.Create();
            xxhash.ComputeHash(Encoding.UTF8.GetBytes(key));

            var mt = new MersenneTwister((int)xxhash.HashUInt32);

            int i = 0;
            while (i < password.Length)
            {
                Array.Copy(BitConverter.GetBytes(mt.Next()), 0, password, i, Math.Min(4, password.Length - i));
                i += 4;
            }

            return password;
        }

#if DEBUG
        public static void DumpExcels(string bytesDir, string destDir)
        {
            foreach (var type in Assembly.GetAssembly(typeof(AcademyFavorScheduleExcelTable))!.GetTypes().Where(t => t.IsAssignableTo(typeof(IFlatbufferObject)) && t.Name.EndsWith("ExcelTable")))
            {
                var bytesFilePath = Path.Join(bytesDir, $"{type.Name.ToLower()}.bytes");
                if (!File.Exists(bytesFilePath))
                {
                    Console.WriteLine($"bytes files for {type.Name} not found. skipping...");
                    continue;
                }

                var bytes = File.ReadAllBytes(bytesFilePath);
                TableEncryptionService.XOR(type.Name, bytes);
                var inst = type.GetMethod($"GetRootAs{type.Name}", BindingFlags.Static | BindingFlags.Public, [typeof(ByteBuffer)])!.Invoke(null, [new ByteBuffer(bytes)]);

                var obj = type.GetMethod("UnPack", BindingFlags.Instance | BindingFlags.Public)!.Invoke(inst, null);
                File.WriteAllText(Path.Join(destDir, $"{type.Name}.json"), JsonConvert.SerializeObject(obj, Formatting.Indented, new StringEnumConverter()));
                Console.WriteLine($"Dumped {type.Name} successfully");
            }
        }
#endif
    }
}
