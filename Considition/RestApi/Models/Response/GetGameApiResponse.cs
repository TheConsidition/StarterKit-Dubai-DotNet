using Newtonsoft.Json;

namespace Considition.RestApi.Models.Response
{
    public class GetGameApiResponse : ApiResponse
    {
        [JsonProperty("gameState")]
        public GameState GameState { get; set; }
    }
}
