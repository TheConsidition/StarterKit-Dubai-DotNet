using Newtonsoft.Json;

namespace Considition.RestApi.Models.Response
{
    public class ApiResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
