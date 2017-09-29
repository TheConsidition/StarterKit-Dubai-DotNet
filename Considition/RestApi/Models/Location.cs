using Newtonsoft.Json;

namespace Considition.RestApi.Models
{
    public class Location
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
