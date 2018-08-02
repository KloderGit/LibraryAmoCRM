using Newtonsoft.Json;
using ServiceLibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;

namespace ServiceLibraryAmoCRM.Infarstructure.JsonConverters
{
    internal class SingleOrArrayToArrayConverter<T> : JsonConverter where T: IHaveIdSingle
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object retVal = new Object();
            if (reader.TokenType == JsonToken.StartObject)
            {
                T instance = (T)serializer.Deserialize(reader, typeof(T));

                retVal = instance.Id == 0 ? null : new List<T>() { instance };
            }
            else if (reader.TokenType == JsonToken.StartArray)
            {
                retVal = serializer.Deserialize(reader, objectType);
            }
            return retVal;
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }
}
