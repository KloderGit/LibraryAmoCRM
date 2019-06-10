using LibraryAmoCRM.Infarstructure.JsonConverters;
using LibraryAmoCRM.Interfaces.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Contact 
    {
        // IEntity
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        // IElement
        [JsonProperty(PropertyName = "responsible_user_id")]
        public int ResponsibleUserId { get; set; }

        [JsonProperty(PropertyName = "created_by")]
        public int CreatedBy { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        [JsonConverter(typeof(UnixTimeStampToDateTime))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at", Required = Required.Always)]
        [JsonConverter(typeof(UnixTimeStampToDateTime))]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "account_id")]
        public int AccountId { get; set; }

        [JsonProperty(PropertyName = "group_id")]
        public int GroupId { get; set; }

        // IClient
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "closest_task_at")]
        [JsonConverter(typeof(UnixTimeStampToDateTime))]
        public DateTime ClosestTaskAt { get; set; }

        [JsonProperty(PropertyName = "updated_by")]
        public int UpdatedBy { get; set; }

        // IBindTags
        //[JsonProperty(PropertyName = "tags")]
        //public IEnumerable<ITag> Tags { get; set; }

        // IBindCustomFields
        //[JsonProperty(PropertyName = "custom_fields")]
        //public IEnumerable<ICustomField> CustomFields { get; set; }

        // IBindLeads
        //[JsonProperty(PropertyName = "leads")]
        //public IArrayId Leads { get; set; }

        public IEnumerable<ILead> GetLeads()
        {
            throw new NotImplementedException();
        }

        // IBindCompany
        [JsonProperty(PropertyName = "company")]
        public Company Company { get; set; }
    }
}
