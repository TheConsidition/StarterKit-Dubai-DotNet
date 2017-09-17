using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Considition.RestApi.Models.Objective
{
    public class QuickFarCityVisitObjective : GameObjective
    {
        [JsonProperty("x")]
        public int X
        {
            get { return (int)V1; }
            set { V1 = value; }
        }

        [JsonProperty("y")]
        public int Y
        {
            get { return (int)V2; }
            set { V2 = value; }
        }
    }
}
