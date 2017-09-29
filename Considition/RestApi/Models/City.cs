using Newtonsoft.Json;
using System.Collections.Generic;

namespace Considition.RestApi.Models
{
    public class City : Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hasFlightTo")]
        public List<string> HasFlightTo { get; set; }

        [JsonProperty("hasTrainTo")]
        public List<string> HasTrainTo { get; set; }

        [JsonProperty("hasBusTo")]
        public List<string> HasBusTo { get; set; }
    }
}
