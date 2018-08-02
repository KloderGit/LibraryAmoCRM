using Newtonsoft.Json;
using ServiceLibraryAmoCRM.Infarstructure.Event;
using ServiceLibraryAmoCRM.Infarstructure.JsonConverters;
using System;

namespace ServiceLibraryAmoCRM.Models
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