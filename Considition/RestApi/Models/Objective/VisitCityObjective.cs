using Newtonsoft.Json;

namespace Considition.RestApi.Models.Objective
{
    public class VisitCityObjective : GameObjective
    {
        [JsonProperty("x")]
        public string X
        {
            get { return (string)V1; }
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
