using LibraryAmoCRM.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryAmoCRM.Converters
{
    public class ObjectIDToArrayJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var array = ((IEnumerable<int>)value).ToList<int>(); ;
            var result = new RelatedEntities{ id = array };

            serializer.Serialize(writer, result);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object result = new Object();

            RelatedEntities instance = (RelatedEntities)serializer.Deserialize(reader, typeof(RelatedEntities));

            if (instance?.id == null || instance.id.Count() == 0) { result = new List<int>(); }
            else { result = new List<int>(instance.id); }

            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
