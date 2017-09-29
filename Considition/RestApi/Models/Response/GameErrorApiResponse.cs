using Newtonsoft.Json;

namespace Considition.RestApi.Models.Response
{
    public class GameErrorApiResponse : ApiResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
