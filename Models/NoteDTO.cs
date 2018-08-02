using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibraryAmoCRM.Models
{
    public class NoteDTO : BasicServiceEntity
    {
        [JsonProperty(PropertyName = "is_editable")]
        public bool? IsEditable { get; set; }

        [JsonProperty(PropertyName = "attachment")]
        public string Attachment { get; set; }

        [JsonProperty(PropertyName = "note_type")]
        public int? NoteType { get; set; }
    }
}
