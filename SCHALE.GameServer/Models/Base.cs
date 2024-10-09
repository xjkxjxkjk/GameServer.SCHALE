using System.Text.Json.Serialization;

namespace SCHALE.GameServer.Models
{
    class BaseResponse
    {
        [JsonPropertyName("result")]
        public int Result { get; set; }
    }
}
