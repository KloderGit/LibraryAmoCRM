using Newtonsoft.Json;
using LibraryAmoCRM.Models.Fields;
using LibraryAmoCRM.Infarstructure;
using LibraryAmoCRM.Infarstructure.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class LeadDTO : BasicMemberEntity
    {

        [JsonProperty(PropertyName = "is_deleted")]
        public bool? IsDeleted { get; set; }

        [JsonConverter(typeof(UnixTimeStampToDateTime))]
        [JsonProperty(PropertyName = "closed_at")]
        public DateTime? ClosedAt { get; set; }

        [JsonProperty(PropertyName = "company")]
        [JsonConverter(typeof(SingleOrArrayToValueConverter<CompanyField>))]
        public CompanyField Company { get; set; }

        [JsonProperty(PropertyName = "contacts")]
        [JsonConverter(typeof(ContactFieldsSerializeConverter<ContactsField>))]
        public ContactsField Contacts { get; set; }

        [JsonProperty(PropertyName = "main_contact")]
        [JsonConverter(typeof(SingleOrArrayToValueConverter<MainContactField>))]
        public MainContactField MainContact { get; set; }

        [JsonProperty(PropertyName = "status_id")]
        public Int32? Status { get; set; }

        [JsonProperty(PropertyName = "sale")]
        public Int32? Price { get; set; }

        [JsonProperty(PropertyName = "loss_reason_id")]
        public Int32? LossReason { get; set; }

        [JsonProperty(PropertyName = "pipeline")]
        [JsonConverter(typeof(SingleOrArrayToValueConverter<PipelineField>))]
        public PipelineField Pipeline { get; set; }
    }
}