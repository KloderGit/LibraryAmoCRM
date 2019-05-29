using Newtonsoft.Json;
using LibraryAmoCRM.Infarstructure.Event;
using LibraryAmoCRM.Infarstructure.JsonConverters;
using System;

namespace LibraryAmoCRM.Models
{
    public class ContactDTO : BasicMemberEntity
    {
        [JsonProperty(PropertyName = "updated_by")]
        public int? UpdatedBy { get; set; }

        [JsonProperty(PropertyName = "leads")]
        [JsonConverter(typeof(LeadFieldsSerializeConverter<LeadsField>))]
        public LeadsField Leads { get; set; }

        [JsonProperty(PropertyName = "company")]
        [JsonConverter(typeof(CompanyFieldSrializeConverter<CompanyField>))]
        public CompanyField Company { get; set; }
    }
}