using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
