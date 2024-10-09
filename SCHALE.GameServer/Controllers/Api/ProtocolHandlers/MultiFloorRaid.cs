using SCHALE.Common.Database;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Services;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class MultiFloorRaid : ProtocolHandlerBase
    {
        private readonly ISessionKeyService sessionKeyService;
        private readonly SCHALEContext context;
        private readonly ExcelTableService excelTableService;

        public MultiFloorRaid(IProtocolHandlerFactory protocolHandlerFactory, ISessionKeyService _sessionKeyService, SCHALEContext _context, ExcelTableService _excelTableService) : base(protocolHandlerFactory)
        {
            sessionKeyService = _sessionKeyService;
            context = _context;
            excelTableService = _excelTableService;
        }

        [ProtocolHandler(Protocol.MultiFloorRaid_Sync)]
        public ResponsePacket SyncHandler(MultiFloorRaidSyncRequest req)
        {
            return new MultiFloorRaidSyncResponse()
            {
                MultiFloorRaidDBs = [
                    new() {
                        SeasonId = 2,
                        ClearBattleFrame = -1
                    }
                ]
            };
        }

        [ProtocolHandler(Protocol.MultiFloorRaid_EnterBattle)]
        public ResponsePacket EnterBattleHandler(MultiFloorRaidEnterBattleRequest req)
        {
            return new MultiFloorRaidEnterBattleResponse();
        }

        [ProtocolHandler(Protocol.MultiFloorRaid_EndBattle)]
        public ResponsePacket EndBattleHandler(MultiFloorRaidEndBattleRequest req)
        {
            return new MultiFloorRaidEndBattleResponse();
        }

    }
}
