namespace SCHALE.Common.NetworkProtocol
{
    public class ErrorPacket : ResponsePacket
    {
        public override Protocol Protocol => Protocol.Error;

        public string? Reason { get; set; }

        public WebAPIErrorCode ErrorCode { get; set; }
    }
}
