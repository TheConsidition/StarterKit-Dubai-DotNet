using Considition.RestApi.Models.Objective;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Considition.RestApi.Models
{
    public class GameState
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cities")]
        public List<City> Cities { get; set; }

        [JsonProperty("transportation")]
        public List<TransportationMethod> Transportation { get; set; }

        [JsonProperty("objectives")]
        public List<GameObjective> Objectives { get; set; }

        [JsonProperty("timeLimit")]
        public int TimeLimit { get; set; }

        [JsonProperty("pollutionsPointRate")]
        public double PollutionsPointRate { get; set; }

        [JsonProperty("start")]
        public Location Start { get; set; }

        [JsonProperty("end")]
        public Location End { get; set; }

        [JsonProperty("map", NullValueHandling = NullValueHandling.Ignore)]
        public char[,] Map { get; set; }
    }
}
