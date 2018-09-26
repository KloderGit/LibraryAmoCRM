using Newtonsoft.Json;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.JsonConverters
{
    internal class CompanyFieldSrializeConverter<T> : JsonConverter where T : CompanyField
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            T result = (T)value;

            serializer.Serialize(writer, result.Id.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object result = new object();

                T instance = (T)serializer.Deserialize(reader, typeof(T));

                if (instance.Id == null || instance.Id == 0)
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
            return false;
        }
    }
}
