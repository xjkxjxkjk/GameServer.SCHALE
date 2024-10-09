using Microsoft.AspNetCore.Http.Connections;
using SCHALE.Common.Database;
using SCHALE.Common.Database.ModelExtensions;
using SCHALE.Common.FlatData;
using SCHALE.Common.Utils;
using SCHALE.GameServer.Controllers.Api.ProtocolHandlers;
using SCHALE.GameServer.Services;
using SCHALE.GameServer.Services.Irc;

namespace SCHALE.GameServer.Commands
{
    [CommandHandler("character", "Command to interact with user's characters", "/character <add|clear|new> [all|characterId]")]
    internal class CharacterCommand : Command
    {
        private static readonly List<uint> NewUids = new List<uint>
        {
            10094, 10095, 10096, 10097, 10098, 10099, 10100, 10101, 10102,
            19018, 19019, 19020, 20036, 20037, 26012, 26013
        };

        public CharacterCommand(IrcConnection connection, string[] args, bool validate = true) : base(connection, args, validate) { }

        [Argument(0, @"^add$|^clear$|^new$", "The operation selected (add, clear, new)", ArgumentFlags.IgnoreCase)]
        public string Op { get; set; } = string.Empty;

        [Argument(1, @"^[0-9]+$|^all$", "The target character, value is item id or 'all'", ArgumentFlags.Optional)]
        public string Target { get; set; } = string.Empty;

        public override void Execute()
        {
            var characterDB = connection.Context.Characters;

            switch (Op.ToLower())
            {
                case "add":
                    if (Target == "all")
                    {
                        InventoryUtils.AddAllCharacters(connection);
                        connection.SendChatMessage("All Characters Added!");
                    }
                    else if (uint.TryParse(Target, out uint characterId))
                    {
                        var newChar = InventoryUtils.CreateMaxCharacterFromId(characterId);
                        
                        if (characterDB.Any(x => x.UniqueId == newChar.UniqueId))
                        {
                            connection.SendChatMessage($"{newChar.UniqueId} already exists!");
                            return;
                        }

                        connection.Account.AddCharacters(connection.Context, new[] { newChar });
                        connection.SendChatMessage($"{newChar.UniqueId} added!");
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Target / Amount!");
                    }
                    break;
                
                case "new":
                    foreach (var uid in NewUids)
                    {
                        var newChar = InventoryUtils.CreateMaxCharacterFromId(uid);

                        if (characterDB.Any(x => x.UniqueId == newChar.UniqueId))
                        {
                            connection.SendChatMessage($"{newChar.UniqueId} already exists!");
                            continue;
                        }

                        connection.Account.AddCharacters(connection.Context, new[] { newChar });
                    }

                    connection.SendChatMessage("New Characters Added!");
                    break;

                case "clear":
                    InventoryUtils.RemoveAllCharacters(connection);
                    connection.SendChatMessage($"Removed all characters!");
                    break;
                
                default:
                    connection.SendChatMessage($"Usage: /character <add|clear|new> [all|characterId]");
                    throw new InvalidOperationException("Invalid operation!");
            }

            connection.Context.SaveChanges();
        }
    }
}
