using Newtonsoft.Json;

namespace Considition.RestApi.Models.Objective
{
    public class VisitManyCitiesObjective : GameObjective
    {
        [JsonProperty("x")]
        public int X
        {
            get { return (int)V1; }
            set { V1 = value; }
        }
    }
}
