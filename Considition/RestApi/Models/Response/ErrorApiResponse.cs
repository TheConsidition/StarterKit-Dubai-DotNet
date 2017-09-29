using Newtonsoft.Json;

namespace Considition.RestApi.Models.Response
{
    public class ErrorApiResponse : ApiResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
