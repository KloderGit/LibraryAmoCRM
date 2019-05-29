using Newtonsoft.Json;
using LibraryAmoCRM.Infarstructure.JsonConverters;
using LibraryAmoCRM.Interfaces;
using System;

namespace LibraryAmoCRM.Models
{
    public abstract class CoreDTO : IHaveIdSingle
    {
        [JsonProperty(PropertyName = "id")]
        public Int32? Id { get; set; }

        [JsonProperty(PropertyName = "responsible_user_id")]
        public Int32? ResponsibleUserId { get; set; }

        [JsonProperty(PropertyName = "created_by")]
        public Int32? CreatedBy { get; set; }

        [JsonConverter(typeof(UnixTimeStampToDateTime))]
        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonConverter(typeof(UnixTimeStampToDateTime))]
        [JsonProperty(PropertyName = "updated_at", Required = Required.Always)]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "account_id")]
        public Int32? AccountId { get; set; }

        [JsonProperty(PropertyName = "group_id")]
        public Int32? GroupId { get; set; }
    }
}