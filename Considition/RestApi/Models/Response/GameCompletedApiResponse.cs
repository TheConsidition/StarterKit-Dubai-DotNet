﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Considition.RestApi.Models.Response
{
    public class GameCompletedApiResponse : ApiResponse
    {
        [JsonProperty("points")]
        public int Points { get; set; }
    }
}