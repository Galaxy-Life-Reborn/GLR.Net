using System;
using System.Collections.Generic;
using GLR.Net.Entities;
using Newtonsoft.Json;

namespace GLR.Net.JsonConverters
{
    public class FriendsConverter : JsonConverter<BasicProfile[]>
    {
        public override BasicProfile[] ReadJson(JsonReader reader, Type objectType, BasicProfile[] existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var rawFriends = JsonConvert.DeserializeObject<string[]>(reader.Value.ToString());
            var friends = new List<BasicProfile>();
            
            for (int i = 0; i < rawFriends.Length; i++)
            {
                var friendSplit = rawFriends[i].Split('/');

                friends.Add(new BasicProfile(friendSplit[0], friendSplit[1]));
            }

            return friends.ToArray();
        }

        public override void WriteJson(JsonWriter writer, BasicProfile[] value, JsonSerializer serializer)
        {
            /* Never needed */
            throw new NotImplementedException();
        }
    }
}
