using SCHALE.Common.Database;
using SCHALE.Common.Database.ModelExtensions;
using SCHALE.Common.FlatData;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Services;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Account : ProtocolHandlerBase
    {
        private readonly ISessionKeyService sessionKeyService;
        private readonly SCHALEContext context;
        private readonly ExcelTableService excelTableService;

        public Account(
            IProtocolHandlerFactory protocolHandlerFactory,
            ISessionKeyService _sessionKeyService,
            SCHALEContext _context,
            ExcelTableService _excelTableService
        )
            : base(protocolHandlerFactory)
        {
            sessionKeyService = _sessionKeyService;
            context = _context;
            excelTableService = _excelTableService;
        }

        [ProtocolHandler(Protocol.Account_CheckYostar)]
        public ResponsePacket CheckYostarHandler(AccountCheckYostarRequest req)
        {
            string[] uidToken = req.EnterTicket.Split(':');

            var account = context.GuestAccounts.SingleOrDefault(x =>
                x.Uid == long.Parse(uidToken[0]) && x.Token == uidToken[1]
            );

            if (account is null)
            {
                return new AccountCheckYostarResponse()
                {
                    ResultState = 0,
                    ResultMessag = "Invalid account (EnterTicket, AccountCheckYostar)"
                };
            }

            return new AccountCheckYostarResponse()
            {
                ResultState = 1,
                SessionKey =
                    sessionKeyService.Create(account.Uid)
                    ?? new SessionKey() { MxToken = req.EnterTicket }
            };
        }

        [ProtocolHandler(Protocol.Account_Auth)]
        public ResponsePacket AuthHandler(AccountAuthRequest req)
        {
            if (req.SessionKey is null || req.SessionKey.AccountServerId == 0)
            {
                return new ErrorPacket() { ErrorCode = WebAPIErrorCode.AccountAuthNotCreated };
            }
            else
            {
                var account = sessionKeyService.GetAccount(req.SessionKey);

                return new AccountAuthResponse()
                {
                    CurrentVersion = req.Version,
                    AccountDB = account,
                    StaticOpenConditions = new()
                    {
                        { OpenConditionContent.Shop, OpenConditionLockReason.None },
                        { OpenConditionContent.Gacha, OpenConditionLockReason.None },
                        { OpenConditionContent.LobbyIllust, OpenConditionLockReason.None },
                        { OpenConditionContent.Raid, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Cafe, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Unit_Growth_Skill, OpenConditionLockReason.None },
                        { OpenConditionContent.Unit_Growth_LevelUp, OpenConditionLockReason.None },
                        {
                            OpenConditionContent.Unit_Growth_Transcendence,
                            OpenConditionLockReason.None
                        },
                        { OpenConditionContent.WeekDungeon, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Arena, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Academy, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Equip, OpenConditionLockReason.None },
                        { OpenConditionContent.Item, OpenConditionLockReason.None },
                        { OpenConditionContent.Mission, OpenConditionLockReason.None },
                        {
                            OpenConditionContent.WeekDungeon_Chase,
                            OpenConditionLockReason.StageClear
                        },
                        {
                            OpenConditionContent.__Deprecated_WeekDungeon_FindGift,
                            OpenConditionLockReason.None
                        },
                        {
                            OpenConditionContent.__Deprecated_WeekDungeon_Blood,
                            OpenConditionLockReason.None
                        },
                        { OpenConditionContent.Story_Sub, OpenConditionLockReason.None },
                        { OpenConditionContent.Story_Replay, OpenConditionLockReason.None },
                        { OpenConditionContent.None, OpenConditionLockReason.None },
                        { OpenConditionContent.Shop_Gem, OpenConditionLockReason.None },
                        { OpenConditionContent.Craft, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Student, OpenConditionLockReason.None },
                        { OpenConditionContent.GuideMission, OpenConditionLockReason.None },
                        { OpenConditionContent.Clan, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Echelon, OpenConditionLockReason.None },
                        { OpenConditionContent.Campaign, OpenConditionLockReason.None },
                        { OpenConditionContent.EventContent, OpenConditionLockReason.None },
                        { OpenConditionContent.EventStage_1, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.EventStage_2, OpenConditionLockReason.None },
                        { OpenConditionContent.Talk, OpenConditionLockReason.None },
                        { OpenConditionContent.Billing, OpenConditionLockReason.None },
                        { OpenConditionContent.Schedule, OpenConditionLockReason.None },
                        { OpenConditionContent.Story, OpenConditionLockReason.None },
                        { OpenConditionContent.Tactic_Speed, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Cafe_Invite, OpenConditionLockReason.StageClear },
                        {
                            OpenConditionContent.Cafe_Invite_2,
                            OpenConditionLockReason.CafeRank | OpenConditionLockReason.StageClear
                        },
                        {
                            OpenConditionContent.EventMiniGame_1,
                            OpenConditionLockReason.StageClear
                        },
                        { OpenConditionContent.SchoolDungeon, OpenConditionLockReason.StageClear },
                        {
                            OpenConditionContent.TimeAttackDungeon,
                            OpenConditionLockReason.StageClear
                        },
                        { OpenConditionContent.ShiftingCraft, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Tactic_Skip, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Mulligan, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.EventPermanent, OpenConditionLockReason.StageClear },
                        {
                            OpenConditionContent.Main_L_1_2,
                            OpenConditionLockReason.ScenarioModeClear
                        },
                        {
                            OpenConditionContent.Main_L_1_3,
                            OpenConditionLockReason.ScenarioModeClear
                        },
                        {
                            OpenConditionContent.Main_L_1_4,
                            OpenConditionLockReason.ScenarioModeClear
                        },
                        { OpenConditionContent.EliminateRaid, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.Cafe_2, OpenConditionLockReason.StageClear },
                        { OpenConditionContent.MultiFloorRaid, OpenConditionLockReason.StageClear }
                    },
                    MissionProgressDBs =
                    [
                        .. context.MissionProgresses.Where(x =>
                            x.AccountServerId == account.ServerId
                        )
                    ]
                };
            }
        }

        [ProtocolHandler(Protocol.Account_Create)]
        public ResponsePacket CreateHandler(AccountCreateRequest req)
        {
            if (req.SessionKey is null)
            {
                return new ErrorPacket() { ErrorCode = WebAPIErrorCode.InvalidSession };
            }

            string[] uidToken = req.SessionKey.MxToken.Split(':');
            var account = new AccountDB(long.Parse(uidToken[0]));

            context.Accounts.Add(account);
            context.SaveChanges();

            // Default items
            context.Items.Add(
                new()
                {
                    AccountServerId = account.ServerId,
                    UniqueId = 2,
                    StackCount = 5
                }
            );

            // Default chars
            var defaultCharacters = excelTableService
                .GetTable<DefaultCharacterExcelTable>()
                .UnPack()
                .DataList;
            var newCharacters = defaultCharacters
                .Select(x =>
                {
                    var characterExcel = excelTableService
                        .GetTable<CharacterExcelTable>()
                        .UnPack()
                        .DataList.Find(y => y.Id == x.CharacterId);

                    return new CharacterDB()
                    {
                        UniqueId = x.CharacterId,
                        StarGrade = x.StarGrade,
                        Level = x.Level,
                        Exp = x.Exp,
                        FavorRank = x.FavorRank,
                        FavorExp = x.FavorExp,
                        PublicSkillLevel = 1,
                        ExSkillLevel = x.ExSkillLevel,
                        PassiveSkillLevel = x.PassiveSkillLevel,
                        ExtraPassiveSkillLevel = x.ExtraPassiveSkillLevel,
                        LeaderSkillLevel = x.LeaderSkillLevel,
                        IsNew = true,
                        IsLocked = true,
                        EquipmentServerIds = characterExcel is not null
                            ? characterExcel.EquipmentSlot.Select(x => (long)0).ToList()
                            : [0, 0, 0],
                        PotentialStats =
                        {
                            { 1, 0 },
                            { 2, 0 },
                            { 3, 0 }
                        }
                    };
                })
                .ToList();

            account.AddCharacters(context, [.. newCharacters]);
            context.SaveChanges();

            var favCharacter = defaultCharacters.Find(x => x.FavoriteCharacter);
            if (favCharacter is not null)
            {
                account.RepresentCharacterServerId = (int)
                    newCharacters.First(x => x.UniqueId == favCharacter.CharacterId).ServerId;
            }
            if (newCharacters.Count > 0)
            {
                context.Echelons.Add(
                    new()
                    {
                        AccountServerId = account.ServerId,
                        EchelonNumber = 1,
                        EchelonType = EchelonType.Adventure,
                        LeaderServerId = newCharacters[0].ServerId,
                        MainSlotServerIds = newCharacters
                            .Take(3)
                            .Select(x => x.ServerId)
                            .Append(0)
                            .ToList(),
                        SupportSlotServerIds = [0, 0]
                    }
                );
            }
            context.SaveChanges();

            return new AccountCreateResponse()
            {
                SessionKey = sessionKeyService.Create(account.PublisherAccountId)
            };
        }

        [ProtocolHandler(Protocol.Account_Nickname)]
        public ResponsePacket NicknameHandler(AccountNicknameRequest req)
        {
            var account = sessionKeyService.GetAccount(req.SessionKey);

            account.Nickname = req.Nickname;
            context.SaveChanges();

            return new AccountNicknameResponse() { AccountDB = account };
        }

        [ProtocolHandler(Protocol.Account_LoginSync)]
        public ResponsePacket LoginSyncHandler(AccountLoginSyncRequest req)
        {
            var account = sessionKeyService.GetAccount(req.SessionKey);
            ArgumentNullException.ThrowIfNull(account);

            return new AccountLoginSyncResponse()
            {
                AccountCurrencySyncResponse = new AccountCurrencySyncResponse()
                {
                    AccountCurrencyDB = new AccountCurrencyDB
                    {
                        AccountLevel = 90,
                        AcademyLocationRankSum = 1,
                        CurrencyDict = new Dictionary<CurrencyTypes, long>
                        {
                            { CurrencyTypes.Gem, long.MaxValue }, // gacha currency 600
                            { CurrencyTypes.GemPaid, 0 },
                            { CurrencyTypes.GemBonus, long.MaxValue }, // default blue gem?
                            { CurrencyTypes.Gold, 962_350_000 }, // credit 10,000
                            { CurrencyTypes.ActionPoint, long.MaxValue }, // energy  24
                            { CurrencyTypes.AcademyTicket, 3 },
                            { CurrencyTypes.ArenaTicket, 5 },
                            { CurrencyTypes.RaidTicket, 3 },
                            { CurrencyTypes.WeekDungeonChaserATicket, 0 },
                            { CurrencyTypes.WeekDungeonChaserBTicket, 0 },
                            { CurrencyTypes.WeekDungeonChaserCTicket, 0 },
                            { CurrencyTypes.SchoolDungeonATicket, 0 },
                            { CurrencyTypes.SchoolDungeonBTicket, 0 },
                            { CurrencyTypes.SchoolDungeonCTicket, 0 },
                            { CurrencyTypes.TimeAttackDungeonTicket, 3 },
                            { CurrencyTypes.MasterCoin, 0 },
                            { CurrencyTypes.WorldRaidTicketA, 40 },
                            { CurrencyTypes.WorldRaidTicketB, 40 },
                            { CurrencyTypes.WorldRaidTicketC, 40 },
                            { CurrencyTypes.ChaserTotalTicket, 6 },
                            { CurrencyTypes.SchoolDungeonTotalTicket, 6 },
                            { CurrencyTypes.EliminateTicketA, 1 },
                            { CurrencyTypes.EliminateTicketB, 1 },
                            { CurrencyTypes.EliminateTicketC, 1 },
                            { CurrencyTypes.EliminateTicketD, 1 }
                        },
                        UpdateTimeDict = new Dictionary<CurrencyTypes, DateTime>
                        {
                            { CurrencyTypes.ActionPoint, DateTime.Parse("2024-04-26T19:29:12") },
                            { CurrencyTypes.AcademyTicket, DateTime.Parse("2024-04-26T19:29:12") },
                            { CurrencyTypes.ArenaTicket, DateTime.Parse("2024-04-26T19:29:12") },
                            { CurrencyTypes.RaidTicket, DateTime.Parse("2024-04-26T19:29:12") },
                            {
                                CurrencyTypes.WeekDungeonChaserATicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.WeekDungeonChaserBTicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.WeekDungeonChaserCTicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.SchoolDungeonATicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.SchoolDungeonBTicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.SchoolDungeonCTicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.TimeAttackDungeonTicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            { CurrencyTypes.MasterCoin, DateTime.Parse("2024-04-26T19:29:12") },
                            {
                                CurrencyTypes.WorldRaidTicketA,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.WorldRaidTicketB,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.WorldRaidTicketC,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.ChaserTotalTicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.SchoolDungeonTotalTicket,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.EliminateTicketA,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.EliminateTicketB,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.EliminateTicketC,
                                DateTime.Parse("2024-04-26T19:29:12")
                            },
                            {
                                CurrencyTypes.EliminateTicketD,
                                DateTime.Parse("2024-04-26T19:29:12")
                            }
                        }
                    }
                },
                CharacterListResponse = new CharacterListResponse()
                {
                    CharacterDBs = [.. account.Characters],
                    TSSCharacterDBs = [],
                    WeaponDBs = [.. account.Weapons],
                    CostumeDBs = [],
                },
                ItemListResponse = new ItemListResponse() { ItemDBs = [.. account.Items], },

                EchelonListResponse = new EchelonListResponse()
                {
                    EchelonDBs = [.. account.Echelons]
                },

                MemoryLobbyListResponse = new MemoryLobbyListResponse()
                {
                    MemoryLobbyDBs = [.. account.MemoryLobbies]
                },

                EventContentPermanentListResponse = new EventContentPermanentListResponse()
                {
                    PermanentDBs =
                    [
                        new() { EventContentId = 900801 },
                        new() { EventContentId = 900802 },
                        new() { EventContentId = 900803 },
                        new() { EventContentId = 900804 },
                        new() { EventContentId = 900805 },
                        new() { EventContentId = 900806 },
                        new() { EventContentId = 900808 },
                        new() { EventContentId = 900809 },
                        new() { EventContentId = 900810 },
                        new() { EventContentId = 900812 },
                        new() { EventContentId = 900813 },
                        new() { EventContentId = 900816 },
                        new() { EventContentId = 900701 },
                    ],
                },

                EquipmentItemListResponse = new EquipmentItemListResponse()
                {
                    EquipmentDBs = [.. account.Equipment]
                },

                CharacterGearListResponse = new CharacterGearListResponse()
                {
                    GearDBs = [.. account.Gears]
                },

                ClanLoginResponse = new ClanLoginResponse()
                {
                    AccountClanMemberDB = new() { AccountId = account.ServerId }
                },

                ScenarioListResponse = new ScenarioListResponse()
                {
                    ScenarioHistoryDBs = [.. account.Scenarios]
                },

                EliminateRaidLoginResponse = new EliminateRaidLoginResponse()
                {
                    SeasonType = RaidSeasonType.Open,
                    SweepPointByRaidUniqueId = new()
                    {
                        { 2041104, int.MaxValue },
                        { 2041204, int.MaxValue }
                    }
                },

                FriendCode = "SCHALE",
            };
        }

        [ProtocolHandler(Protocol.Account_GetTutorial)]
        public ResponsePacket GetTutorialHandler(AccountGetTutorialRequest req)
        {
            var tutorialIds = context
                .AccountTutorials.SingleOrDefault(x =>
                    x.AccountServerId == sessionKeyService.GetAccount(req.SessionKey).ServerId
                )
                ?.TutorialIds;

            return new AccountGetTutorialResponse()
            {
                TutorialIds = tutorialIds ?? Enumerable.Range(1, 27).Select(i => (long)i).ToList()
            };
        }

        [ProtocolHandler(Protocol.Account_SetTutorial)]
        public ResponsePacket SetTutorialHandler(AccountSetTutorialRequest req)
        {
            var account = sessionKeyService.GetAccount(req.SessionKey);
            var tutorial = context.AccountTutorials.SingleOrDefault(x =>
                x.AccountServerId == account.ServerId
            );
            if (tutorial == null)
            {
                tutorial = new()
                {
                    AccountServerId = account.ServerId,
                    TutorialIds = req.TutorialIds
                };
                context.AccountTutorials.Add(tutorial);
            }
            else
            {
                tutorial.TutorialIds = req.TutorialIds;
            }
            context.SaveChanges();

            return new AccountSetTutorialResponse();
        }


        [ProtocolHandler(Protocol.Account_SetRepresentCharacterAndComment)]
        public ResponsePacket SetRepresentCharacterAndCommentHandler(AccountSetRepresentCharacterAndCommentRequest req)
        {
            var account = sessionKeyService.GetAccount(req.SessionKey);

            account.RepresentCharacterServerId = req.RepresentCharacterServerId;
            account.Comment = req.Comment;

            context.SaveChanges();

            return new AccountSetRepresentCharacterAndCommentResponse()
            {
                AccountDB = account,
                RepresentCharacterDB = account.Characters.FirstOrDefault(x => x.ServerId == req.RepresentCharacterServerId)
            };
        }

        // TODO: others handlers, move to different handler group later
        [ProtocolHandler(Protocol.NetworkTime_Sync)]
        public ResponsePacket NetworkTime_SyncHandler(NetworkTimeSyncRequest req)
        {
            return new NetworkTimeSyncResponse()
            {
                ReceiveTick = DateTimeOffset.Now.Ticks,
                EchoSendTick = DateTimeOffset.Now.Ticks
            };
        }

        [ProtocolHandler(Protocol.ContentSave_Get)]
        public ResponsePacket ContentSave_GetHandler(ContentSaveGetRequest req)
        {
            return new ContentSaveGetResponse();
        }

        [ProtocolHandler(Protocol.Toast_List)]
        public ResponsePacket ToastListHandler(ToastListRequest req)
        {
            return new ToastListResponse();
        }

        [ProtocolHandler(Protocol.ContentLog_UIOpenStatistics)]
        public ResponsePacket ContentLog_UIOpenStatisticsHandler(
            ContentLogUIOpenStatisticsRequest req
        )
        {
            return new ContentLogUIOpenStatisticsResponse();
        }

        [ProtocolHandler(Protocol.Event_RewardIncrease)]
        public ResponsePacket Event_RewardIncreaseHandler(EventRewardIncreaseRequest req)
        {
            return new EventRewardIncreaseResponse();
        }

        [ProtocolHandler(Protocol.OpenCondition_EventList)]
        public ResponsePacket OpenCondition_EventListHandler(OpenConditionEventListRequest req)
        {
            return new OpenConditionEventListResponse()
            {
                // all open for now ig
                StaticOpenConditions = Enum.GetValues(typeof(OpenConditionContent))
                    .Cast<OpenConditionContent>()
                    .ToDictionary(key => key, key => OpenConditionLockReason.None)
            };
        }

        [ProtocolHandler(Protocol.Notification_EventContentReddotCheck)]
        public ResponsePacket Notification_EventContentReddotCheckHandler(
            NotificationEventContentReddotRequest req
        )
        {
            return new NotificationEventContentReddotResponse();
        }

        [ProtocolHandler(Protocol.Billing_PurchaseListByYostar)]
        public ResponsePacket Billing_PurchaseListByYostarHandler(
            BillingPurchaseListByYostarRequest req
        )
        {
            return new BillingPurchaseListByYostarResponse();
        }

        [ProtocolHandler(Protocol.WeekDungeon_List)]
        public ResponsePacket WeekDungeon_ListHandler(WeekDungeonListRequest req)
        {
            return new WeekDungeonListResponse();
        }

        [ProtocolHandler(Protocol.SchoolDungeon_List)]
        public ResponsePacket SchoolDungeon_ListHandler(SchoolDungeonListRequest req)
        {
            return new SchoolDungeonListResponse();
        }

        [ProtocolHandler(Protocol.MiniGame_MissionList)]
        public ResponsePacket MiniGame_MissionListHandler(MiniGameMissionListRequest req)
        {
            return new MiniGameMissionListResponse();
        }

        [ProtocolHandler(Protocol.Attachment_EmblemAcquire)]
        public ResponsePacket Attachment_EmblemAcquireHandler(AttachmentEmblemAcquireRequest req)
        {
            return new AttachmentEmblemAcquireResponse();
        }

        [ProtocolHandler(Protocol.Friend_List)]
        public ResponsePacket Attachment_EmblemAcquireHandler(FriendListRequest req)
        {
            return new FriendListResponse();
        }

        [ProtocolHandler(Protocol.Friend_GetIdCard)]
        public ResponsePacket Friend_GetIdCardHandler(FriendGetIdCardRequest req)
        {
            return new FriendGetIdCardResponse();
        }

        
    }
}
