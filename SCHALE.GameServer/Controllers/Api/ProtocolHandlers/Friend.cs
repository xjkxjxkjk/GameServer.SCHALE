using SCHALE.Common.NetworkProtocol;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Friend : ProtocolHandlerBase
    {
        public Friend(IProtocolHandlerFactory protocolHandlerFactory) : base(protocolHandlerFactory) { }

        [ProtocolHandler(Protocol.Friend_Check)]
        public ResponsePacket CheckHandler(FriendCheckRequest req)
        {

            return new FriendCheckResponse()
            {
                
            };
        }
    }
}
