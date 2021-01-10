using System;
using GLR.Net.Entities;
using Newtonsoft.Json;

namespace GLR.Net.JsonConverters
{
    public class RankConverter : JsonConverter<RankInfo>
    {
        public override RankInfo ReadJson(JsonReader reader, Type objectType, RankInfo existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var rankType = (int) reader.ReadAsInt32();
            return new RankInfo(rankType);
        }

        public override void WriteJson(JsonWriter writer, RankInfo value, JsonSerializer serializer)
        {
            /* Never needed */
            throw new NotImplementedException();
        }
    }
}
