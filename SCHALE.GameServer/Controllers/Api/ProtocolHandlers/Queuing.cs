﻿using SCHALE.Common.NetworkProtocol;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Queuing : ProtocolHandlerBase
    {
        public Queuing(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Queuing_GetTicket)]
        public ResponsePacket GetTicketHandler(QueuingGetTicketRequest req)
        {
            return new QueuingGetTicketResponse()
            {
                EnterTicket = $"{req.YostarUID}:{req.YostarToken}"
            };
        }
    }
}
