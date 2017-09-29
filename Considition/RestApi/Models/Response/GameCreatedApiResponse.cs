using Newtonsoft.Json;

namespace Considition.RestApi.Models.Response
{
    public class GameCreatedApiResponse : ApiResponse
    {
        [JsonProperty("gameId")]
        public int GameId { get; set; }
    }
}
