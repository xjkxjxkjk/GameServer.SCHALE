﻿using SCHALE.Common.Database;
using SCHALE.Common.Database.ModelExtensions;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Services;
using Serilog;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Scenario : ProtocolHandlerBase
    {
        private readonly ISessionKeyService sessionKeyService;
        private readonly SCHALEContext context;
        private readonly ExcelTableService excelTableService;

        public Scenario(IProtocolHandlerFactory protocolHandlerFactory, ISessionKeyService _sessionKeyService, SCHALEContext _context, ExcelTableService _excelTableService) : base(protocolHandlerFactory)
        {
            sessionKeyService = _sessionKeyService;
            context = _context;
            excelTableService = _excelTableService;
        }

        [ProtocolHandler(Protocol.Scenario_Skip)]
        public ResponsePacket SkipHandler(ScenarioSkipRequest req)
        {
            return new ScenarioSkipResponse();
        }

        [ProtocolHandler(Protocol.Scenario_Select)]
        public ResponsePacket SelectHandler(ScenarioSelectRequest req)
        {
            return new ScenarioSelectResponse();
        }

        [ProtocolHandler(Protocol.Scenario_GroupHistoryUpdate)]
        public ResponsePacket GroupHistoryUpdateHandler(ScenarioGroupHistoryUpdateRequest req)
        {
            return new ScenarioGroupHistoryUpdateResponse();
        }
        
        [ProtocolHandler(Protocol.Scenario_LobbyStudentChange)]
        public ResponsePacket LobbyStudentChangeHandler(ScenarioLobbyStudentChangeRequest req)
        {
            return new ScenarioLobbyStudentChangeResponse();
        }

        [ProtocolHandler(Protocol.Scenario_AccountStudentChange)]
        public ResponsePacket AccountStudentChangeHandler(ScenarioAccountStudentChangeRequest req)
        {
            return new ScenarioAccountStudentChangeResponse();
        }

        [ProtocolHandler(Protocol.Scenario_Clear)]
        public ResponsePacket ClearHandler(ScenarioClearRequest req)
        {
            var account = sessionKeyService.GetAccount(req.SessionKey);

            var scenario = account.Scenarios.FirstOrDefault(x => x.ScenarioUniqueId == req.ScenarioId);

            if (scenario == null)
            {
                scenario = new ScenarioHistoryDB()
                {
                    ScenarioUniqueId = req.ScenarioId,
                    ClearDateTime = DateTime.UtcNow,
                };

                account.AddScenarios(context, [scenario]);
                context.SaveChanges();
            }

            return new ScenarioClearResponse()
            {
                ScenarioHistoryDB = scenario
            };
        }
    }
}
