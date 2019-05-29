using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class NoteDTO : BasicServiceEntity
    {
        [JsonProperty(PropertyName = "is_editable")]
        public bool? IsEditable { get; set; }

        [JsonProperty(PropertyName = "attachment")]
        public string Attachment { get; set; }

        [JsonProperty(PropertyName = "note_type")]
        public int? NoteType { get; set; }

        [JsonProperty(PropertyName = "params")]
        public NoteParams Params { get; set; }
    }

    public class NoteParams
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }
    }
}
