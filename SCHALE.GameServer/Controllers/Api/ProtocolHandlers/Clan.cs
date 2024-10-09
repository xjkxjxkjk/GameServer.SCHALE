using SCHALE.Common.Database;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Services;
using SCHALE.GameServer.Utils;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Clan : ProtocolHandlerBase
    {
        private readonly ISessionKeyService sessionKeyService;
        private readonly SCHALEContext context;
        private readonly ExcelTableService excelTableService;

        public Clan(IProtocolHandlerFactory protocolHandlerFactory, ISessionKeyService _sessionKeyService, SCHALEContext _context, ExcelTableService _excelTableService) : base(protocolHandlerFactory)
        {
            sessionKeyService = _sessionKeyService;
            context = _context;
            excelTableService = _excelTableService;
        }

        [ProtocolHandler(Protocol.Clan_Lobby)]
        public ResponsePacket CheckHandler(ClanLobbyRequest req)
        {
            var account = sessionKeyService.GetAccount(req.SessionKey);

            return new ClanLobbyResponse()
            {
                IrcConfig = new()
                {
                    HostAddress = Config.Instance.IRCAddress,
                    Port = Config.Instance.IRCPort,
                    Password = ""
                },
                AccountClanDB = new()
                {
                    ClanDBId = 777,
                    ClanName = "Nexon",
                    ClanChannelName = "channel_1",
                    ClanPresidentNickName = "Arona",
                    ClanPresidentRepresentCharacterUniqueId = 10000,
                    ClanNotice = "",
                    ClanMemberCount = 1,
                },
                AccountClanMemberDB = new()
                {
                    AccountId = account.ServerId,
                    AccountLevel = account.Level,
                    ClanDBId = 777,
                    RepresentCharacterUniqueId = 10000,
                    ClanSocialGrade = Common.FlatData.ClanSocialGrade.Member,
                    AccountNickName = account.Nickname
                },
                ClanMemberDBs = [
                    new() {
                        AccountId = account.ServerId,
                        AccountLevel = account.Level,
                        ClanDBId = 777,
                        RepresentCharacterUniqueId = 10000,
                        AttendanceCount = 33,
                        ClanSocialGrade = Common.FlatData.ClanSocialGrade.Member,
                        AccountNickName = account.Nickname,
                        AttachmentDB = new() {
                            AccountId = account.ServerId,
                            EmblemUniqueId = 123123
                        }
                    }
                ],
                
            };
        }

        [ProtocolHandler(Protocol.Clan_Check)]
        public ResponsePacket CheckHandler(ClanCheckRequest req)
        {
            return new ClanCheckResponse();
        }

        [ProtocolHandler(Protocol.Clan_AllAssistList)]
        public ResponsePacket AllAssistListHandler(ClanAllAssistListRequest req)
        {
            return new ClanAllAssistListResponse()
            {
                AssistCharacterDBs = [
                    new() {
                        AccountId = 1,
                        AssistCharacterServerId = 1,
                        EchelonType = Common.FlatData.EchelonType.Raid,
                        AssistRelation = Common.Database.AssistRelation.Friend,
                        EquipmentDBs = [],
                        WeaponDB = new(),
                        NickName = "Arona",
                        UniqueId = 20024,
                    }
                ],
                AssistCharacterRentHistoryDBs = []
            };
        }

        
    }
}
