using Considition.RestApi.Models.Objective;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Considition.RestApi.Helpers
{
    public class GameObjectiveJsonConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(GameObjective);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            Type type;
            var objectiveType = (string)jObject["type"];
            switch (objectiveType)
            {
                case "long_bike_ride": type = typeof(BikeDistanceObjective); break;
                case "curvy_road": type = typeof(CurvyRoadObjective); break;
                case "far_from_city": type = typeof(FarFromCityObjective); break;
                case "far_from_land": type = typeof(FarFromLandObjective); break;
                case "long_flight": type = typeof(LongFlightObjective); break;
                case "nearby_land": type = typeof(NearbyLandObjective); break;
                case "quick_far_city_visit": type = typeof(QuickFarCityVisitObjective); break;
                case "return_to_city": type = typeof(ReturnToCityObjective); break;
                case "train_both_ways": type = typeof(TrainBothWaysObjective); break;
                case "unique_path": type = typeof(UniquePathObjective); break;
                case "useful_transport_methods": type = typeof(UsefulTransportMethodsObjective); break;
                case "visit_city": type = typeof(VisitCityObjective); break;
                case "visit_many_cities": type = typeof(VisitManyCitiesObjective); break;
                case "visit_small_island": type = typeof(VisitSmallIslandObjective); break;
                default: throw new NotImplementedException();
            }

            return serializer.Deserialize(jObject.CreateReader(), type);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
