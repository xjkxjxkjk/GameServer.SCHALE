using SCHALE.Common.Database;
using SCHALE.Common.FlatData;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Services;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Campaign : ProtocolHandlerBase
    {
        private ISessionKeyService sessionKeyService;
        private SCHALEContext context;

        public Campaign(IProtocolHandlerFactory protocolHandlerFactory, ISessionKeyService _sessionKeyService, SCHALEContext _context) : base(protocolHandlerFactory)
        {
            sessionKeyService = _sessionKeyService;
            context = _context;
        }

        [ProtocolHandler(Protocol.Campaign_List)]
        public ResponsePacket ListHandler(CampaignListRequest req)
        {

            return new CampaignListResponse()
            {

            };
        }

        [ProtocolHandler(Protocol.Campaign_EnterMainStage)]
        public ResponsePacket EnterMainStageHandler(CampaignEnterMainStageRequest req)
        {
            return new CampaignEnterMainStageResponse()
            {
                SaveDataDB = new CampaignMainStageSaveDB()
                {
                    ContentType = ContentType.CampaignMainStage,
                    LastEnemyEntityId = 10010,

                    ActivatedHexaEventsAndConditions = new() { { 0, [0] } },
                    HexaEventDelayedExecutions = [],
                    CreateTime = DateTime.Parse("2024-04-22T18:33:21"),
                    StageUniqueId = 1011101,
                    StageEntranceFee = [],
                    EnemyKillCountByUniqueId = []
                }
            };
        }
    }
}
