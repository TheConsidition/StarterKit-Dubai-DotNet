﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Considition.RestApi.Models
{
    public class TransportationMethod
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; } // Km/h

        [JsonProperty("pollutions")]
        public double Pollutions { get; set; } // Tonne CO2/h

        [JsonProperty("travelInterval")]
        public int? TravelInterval { get; set; } // Transportation is available every x minutes

        [JsonProperty("canUseAnywhere")]
        public bool CanUseAnywhere { get; set; }
    }
}
