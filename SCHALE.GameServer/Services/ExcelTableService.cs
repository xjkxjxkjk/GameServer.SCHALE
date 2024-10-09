using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Google.FlatBuffers;
using Ionic.Zip;
using SCHALE.Common.Crypto;
using SCHALE.GameServer.Utils;
using Serilog;

namespace SCHALE.GameServer.Services
{
    // TODO: High priority, cache UnPack-ed table!
    public class ExcelTableService(ILogger<ExcelTableService> _logger)
    {
        private readonly ILogger<ExcelTableService> logger = _logger;
        private readonly Dictionary<Type, object> caches = [];

        public static async Task LoadExcels(string excelDirectory = "")
        {
            var excelZipUrl = $"https://prod-clientpatch.bluearchiveyostar.com/{Config.Instance.VersionId}/TableBundles/Excel.zip";
            
            var excelDir = string.IsNullOrWhiteSpace(excelDirectory) 
                ? Path.Join(Path.GetDirectoryName(AppContext.BaseDirectory), "Resources/excel")
                : excelDirectory;
            var excelZipPath = Path.Combine(excelDir, "Excel.zip");

            if (Directory.Exists(excelDir))
            {
                Log.Information("Excels already downloaded, skipping...");
                return;
            }
            
            Log.Information("Downloading Excels...");
            Directory.CreateDirectory(excelDir);

            using var client = new HttpClient();
            var zipBytes = await client.GetByteArrayAsync(excelZipUrl);

            File.WriteAllBytes(excelZipPath, zipBytes);

            using (var zip = ZipFile.Read(excelZipPath)) {
                zip.Password = Convert.ToBase64String(TableService.CreatePassword(Path.GetFileName(excelZipPath)));
                zip.ExtractAll(excelDir, ExtractExistingFileAction.OverwriteSilently);
            }

            File.Delete(excelZipPath);
            Log.Information($"Excel Version {Config.Instance.VersionId} downloaded! Notice that versions higher than r67 currently does not work");
        }

        /// <summary>
        /// Please <b>only</b> use this to get table that <b>have a respective file</b> (i.e. <c>CharacterExcelTable</c> have <c>characterexceltable.bytes</c>)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public T GetTable<T>(bool bypassCache = false, string excelDirectory = "") where T : IFlatbufferObject
        {
            var type = typeof(T);

            if (!bypassCache && caches.TryGetValue(type, out var cache))
                return (T)cache;

            var excelDir = string.IsNullOrWhiteSpace(excelDirectory)
                ? Path.Join(Path.GetDirectoryName(AppContext.BaseDirectory), "Resources/excel")
                : excelDirectory;
            var bytesFilePath = Path.Join(excelDir, $"{type.Name.ToLower()}.bytes");
            if (!File.Exists(bytesFilePath))
            {
                throw new FileNotFoundException($"bytes files for {type.Name} not found");
            }

            var bytes = File.ReadAllBytes(bytesFilePath);
            TableEncryptionService.XOR(type.Name, bytes);
            var inst = type.GetMethod($"GetRootAs{type.Name}", BindingFlags.Static | BindingFlags.Public, [typeof(ByteBuffer)])!.Invoke(null, [new ByteBuffer(bytes)]);

            caches.Add(type, inst!);
            logger.LogDebug("{Excel} loaded and cached", type.Name);

            return (T)inst!;
        }
    }

    internal static class ExcelTableServiceExtensions
    {
        public static void AddExcelTableService(this IServiceCollection services)
        {
            services.AddSingleton<ExcelTableService>();
        }
    }
}
