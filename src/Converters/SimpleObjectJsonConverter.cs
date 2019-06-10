using Newtonsoft.Json;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryAmoCRM.DTO;

namespace LibraryAmoCRM.Converters
{
    internal class SimpleObjectJsonConverter<T> : JsonConverter where T : Element
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            T result = (T)value;

            serializer.Serialize(writer, result.id.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object result = new object();

                T instance = (T)serializer.Deserialize(reader, typeof(T));

                if (instance.id == 0)
                {
                    result = null;
                }
                else
                {
                    result = instance;
                }
 
            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
