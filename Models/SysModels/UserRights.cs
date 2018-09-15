using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models.SysModels
{
    public class UserRights
    {
        [JsonProperty(PropertyName = "mail")]
        public string mail { get; set; }

        [JsonProperty(PropertyName = "incoming_leads")]
        public string incoming_leads { get; set; }

        [JsonProperty(PropertyName = "catalogs")]
        public string catalogs { get; set; }

        [JsonProperty(PropertyName = "lead_add")]
        public string lead_add { get; set; }

        [JsonProperty(PropertyName = "lead_view")]
        public string lead_view { get; set; }

        [JsonProperty(PropertyName = "lead_edit")]
        public string lead_edit { get; set; }

        [JsonProperty(PropertyName = "lead_delete")]
        public string lead_delete { get; set; }

        [JsonProperty(PropertyName = "lead_export")]
        public string lead_export { get; set; }

        [JsonProperty(PropertyName = "contact_add")]
        public string contact_add { get; set; }

        [JsonProperty(PropertyName = "contact_view")]
        public string contact_view { get; set; }

        [JsonProperty(PropertyName = "contact_edit")]
        public string contact_edit { get; set; }

        [JsonProperty(PropertyName = "contact_delete")]
        public string contact_delete { get; set; }

        [JsonProperty(PropertyName = "contact_export")]
        public string contact_export { get; set; }

        [JsonProperty(PropertyName = "company_add")]
        public string company_add { get; set; }

        [JsonProperty(PropertyName = "company_view")]
        public string company_view { get; set; }

        [JsonProperty(PropertyName = "company_edit")]
        public string company_edit { get; set; }

        [JsonProperty(PropertyName = "company_delete")]
        public string company_delete { get; set; }

        [JsonProperty(PropertyName = "company_export")]
        public string company_export { get; set; }

        [JsonProperty(PropertyName = "task_edit")]
        public string task_edit { get; set; }

        [JsonProperty(PropertyName = "task_delete")]
        public string task_delete { get; set; }
    }
}
