using Newtonsoft.Json;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryAmoCRM.Infarstructure.JsonConverters
{
    internal class TagFieldSerializeConverter: JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string result;

            if (value != null)
            {
                var array = ((IEnumerable<TagsField>)value).Select(x => x.Name);
                result = String.Join(",", array);
            }
            else {
                result = null;
            }

            serializer.Serialize(writer, result);
        }


        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object retVal = new Object();

            if (reader.TokenType == JsonToken.StartObject)
            {
                TagsField instance = (TagsField)serializer.Deserialize(reader, typeof(TagsField));

                if (instance.Id == null)
                {
                    retVal = null;
                }
                else
                {
                    retVal = instance;
                }
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
