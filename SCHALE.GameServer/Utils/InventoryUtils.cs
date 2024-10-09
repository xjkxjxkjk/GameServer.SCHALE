using SCHALE.Common.Database;
using SCHALE.Common.Database.ModelExtensions;
using SCHALE.Common.FlatData;
using SCHALE.Common.Migrations;
using SCHALE.GameServer.Services;
using SCHALE.GameServer.Services.Irc;
using System;
using System.Data;

namespace SCHALE.Common.Utils
{
    public static class InventoryUtils
    {
        public static void AddAllCharacters(IrcConnection connection)
        {
            var account = connection.Account;
            var context = connection.Context;

            var characterExcel = connection.ExcelTableService.GetTable<CharacterExcelTable>().UnPack().DataList;
            var allCharacters = characterExcel.Where(x =>
                x is
                {
                    IsPlayable: true,
                    IsPlayableCharacter: true,
                    IsNPC: false,
                    ProductionStep: ProductionStep.Release,
                }
            ).Select(x => CreateMaxCharacterFromId(x.Id)).ToList();

            account.AddCharacters(context, [.. allCharacters]);
            context.SaveChanges();

            connection.SendChatMessage("Added all characters!");
        }

        public static void AddAllEquipment(IrcConnection connection)
        {
            var equipmentExcel = connection.ExcelTableService.GetTable<EquipmentExcelTable>().UnPack().DataList;
            var allEquipment = equipmentExcel.Select(x =>
            {
                return new EquipmentDB()
                {
                    UniqueId = x.Id,
                    Level = 1,
                    StackCount = 77777, // ~ 90,000 cap, auto converted if over
                };
            }).ToList();

            connection.Account.AddEquipment(connection.Context, [.. allEquipment]);
            connection.Context.SaveChanges();

            connection.SendChatMessage("Added all equipment!");
        }

        public static void AddAllItems(IrcConnection connection)
        {
            var itemExcel = connection.ExcelTableService.GetTable<ItemExcelTable>().UnPack().DataList;
            var allItems = itemExcel.Select(x =>
            {
                return new ItemDB()
                {
                    IsNew = true,
                    UniqueId = x.Id,
                    StackCount = 1000,
                };
            }).ToList();

            connection.Account.AddItems(connection.Context, [.. allItems]);
            connection.Context.SaveChanges();

            connection.SendChatMessage("Added all items!");
        }

        public static void AddAllWeapons(IrcConnection connection)
        {
            var account = connection.Account;
            var context = connection.Context;

            // only for current characters
            var allWeapons = account.Characters.Select(x =>
            {
                return new WeaponDB()
                {
                    UniqueId = x.UniqueId,
                    BoundCharacterServerId = x.ServerId,
                    IsLocked = false,
                    StarGrade = 3,
                    Level = 50
                };
            });

            account.AddWeapons(context, [.. allWeapons]);
            context.SaveChanges();

            connection.SendChatMessage("Added all weapons!");
        }

        public static void AddAllGears(IrcConnection connection)
        {
            var account = connection.Account;
            var context = connection.Context;

            var gearExcel = connection.ExcelTableService.GetTable<CharacterGearExcelTable>().UnPack().DataList;

            var allGears = gearExcel.Where(x => x.Tier == 2 && context.Characters.Any(y => y.UniqueId == x.CharacterId)).Select(x => new GearDB()
            {
                UniqueId = x.Id,
                Level = 1,
                SlotIndex = 4,
                BoundCharacterServerId = context.Characters.FirstOrDefault(z => z.UniqueId == x.CharacterId).ServerId,
                Tier = 2,
                Exp = 0,
            });

            account.AddGears(context, [.. allGears]);
            context.SaveChanges();

            connection.SendChatMessage("Added all gears!");
        }

        public static void AddAllMemoryLobbies(IrcConnection connection)
        {
            var account = connection.Account;
            var context = connection.Context;

            var memoryLobbyExcel = connection.ExcelTableService.GetTable<MemoryLobbyExcelTable>().UnPack().DataList;
            var allMemoryLobbies = memoryLobbyExcel.Select(x =>
            {
                return new MemoryLobbyDB()
                {
                    MemoryLobbyUniqueId = x.Id,
                };
            }).ToList();

            account.AddMemoryLobbies(context, [.. allMemoryLobbies]);
            context.SaveChanges();

            connection.SendChatMessage("Added all Memory Lobbies!");
        }

        public static void AddAllScenarios(IrcConnection connection)
        {
            var account = connection.Account;
            var context = connection.Context;

            var scenarioModeExcel = connection.ExcelTableService.GetTable<ScenarioModeExcelTable>().UnPack().DataList;
            var allScenarios = scenarioModeExcel.Select(x =>
            {
                return new ScenarioHistoryDB()
                {
                    ScenarioUniqueId = x.ModeId,
                };
            }).ToList();

            account.AddScenarios(context, [.. allScenarios]);
            context.SaveChanges();

            connection.SendChatMessage("Added all Scenarios!");
        }

        public static void RemoveAllCharacters(IrcConnection connection) // removing default characters breaks game
        {
            var characterDB = connection.Context.Characters;
            var defaultCharacters = connection.ExcelTableService.GetTable<DefaultCharacterExcelTable>().UnPack().DataList.Select(x => x.CharacterId).ToList();

            var removed = characterDB.Where(x => x.AccountServerId == connection.AccountServerId && !defaultCharacters.Contains(x.UniqueId));

            characterDB.RemoveRange(removed);

            connection.SendChatMessage("Removed all characters!");
        }

        public static CharacterDB CreateMaxCharacterFromId(long characterId)
        {
            return new CharacterDB()
            {
                UniqueId = characterId,
                StarGrade = 5,
                Level = 90,
                Exp = 0,
                PublicSkillLevel = 10,
                ExSkillLevel = 5,
                PassiveSkillLevel = 10,
                ExtraPassiveSkillLevel = 10,
                LeaderSkillLevel = 1,
                FavorRank = 20,
                IsNew = true,
                IsLocked = true,
                PotentialStats = { { 1, 0 }, { 2, 0 }, { 3, 0 } },
                EquipmentServerIds = [0, 0, 0]
            };
        }
    }
}
