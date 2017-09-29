using Newtonsoft.Json;

namespace Considition.RestApi.Models.Objective
{
    public class GameObjective
    {
        [JsonProperty(PropertyName = "x", NullValueHandling = NullValueHandling.Ignore)]
        protected virtual object V1 { get; set; }

        [JsonProperty(PropertyName = "y", NullValueHandling = NullValueHandling.Ignore)]
        protected virtual object V2 { get; set; }

        [JsonProperty(PropertyName = "z", NullValueHandling = NullValueHandling.Ignore)]
        protected virtual object V3 { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }
    }
}
