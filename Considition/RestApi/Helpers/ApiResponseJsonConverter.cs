using Considition.RestApi.Models.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

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
            var jObject = JObject.Load(reader);
            Type type;
            var objectiveType = (string)jObject["type"];
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
