using Newtonsoft.Json;
using ServiceLibraryAmoCRM.Infarstructure.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models
{
    public class CompanyDTO : BasicMemberEntity
    {
        [JsonProperty(PropertyName = "updated_by")]
        public int? UpdatedBy { get; set; }

        [JsonProperty(PropertyName = "leads")]
        [JsonConverter(typeof(LeadFieldsSerializeConverter<LeadsField>))]
        public LeadsField Leads { get; set; }

        [JsonProperty(PropertyName = "contacts")]
        [JsonConverter(typeof(ContactFieldsSerializeConverter<ContactsField>))]
        public ContactsField Contacts { get; set; }
    }
}