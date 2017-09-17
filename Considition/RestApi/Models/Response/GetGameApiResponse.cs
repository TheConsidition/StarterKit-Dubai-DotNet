using Considition.RestApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Considition.RestApi.Models.Response
{
    public class GetGameApiResponse : ApiResponse
    {
        [JsonProperty("gameState")]
        public GameState GameState { get; set; }
    }
}
