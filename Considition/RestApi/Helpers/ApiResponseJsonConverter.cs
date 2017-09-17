using Considition.RestApi.Models.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Considition.RestApi.Helpers
{
    public class ApiResponseJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ApiResponse);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            Type type;
            string objectiveType = (string)jObject["type"];
            switch (objectiveType)
            {
                case "Error": type = typeof(ErrorApiResponse); break;
                case "GetGame": type = typeof(GetGameApiResponse); break;
                case "GameCompleted": type = typeof(GameCompletedApiResponse); break;
                case "GameCreated": type = typeof(GameCreatedApiResponse); break;
                case "GameError": type = typeof(GameErrorApiResponse); break;
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
