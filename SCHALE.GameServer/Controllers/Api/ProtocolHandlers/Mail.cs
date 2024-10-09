using SCHALE.Common.NetworkProtocol;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Mail : ProtocolHandlerBase
    {
        public Mail(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Mail_Check)]
        public ResponsePacket CheckHandler(MailCheckRequest req)
        {

            return new MailCheckResponse()
            {

            };
        }


    }
}
