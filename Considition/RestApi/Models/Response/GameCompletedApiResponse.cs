using Newtonsoft.Json;

namespace Considition.RestApi.Models.Response
{
    public class GameCompletedApiResponse : ApiResponse
    {
        [JsonProperty("points")]
        public int Points { get; set; }
    }
}
