﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiceLibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServiceLibraryAmoCRM.Infarstructure.JsonConverters
{
    internal class ContactFieldsSerializeConverter<T> : JsonConverter where T : ContactsField
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            IEnumerable<string> result = ((T)value).IDs.Select(y => y.ToString());

            serializer.Serialize(writer, result);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object result = new Object();

                T instance = (T)serializer.Deserialize(reader, typeof(T));

                if (instance.IDs == null)
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
