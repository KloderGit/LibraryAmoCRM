using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.DTO
{
    internal class NoteDTO : IntentDTO
    {
        public int responsible_user_id { get; set; }
        public int created_by { get; set; }
        public uint created_at { get; set; }
        public uint updated_at { get; set; }
        public int account_id { get; set; }
        public int group_id { get; set; }
        public bool? is_editable { get; set; }
        public int element_id { get; set; }
        public int element_type { get; set; }
        public string attachment { get; set; }
        public int note_type { get; set; }
        public NoteParamsDTO @params { get; set; }
    }

    internal class NoteParamsDTO
    {
        public string text { get; set; }
        public string service { get; set; }

        public string sender { get; set; }
        public string html { get; set; }

        public string uniq { get; set; }
        public string link { get; set; }
        public string phone { get; set; }
        public int duration { get; set; }
        public string from { get; set; }
        public string src { get; set; }
        public string call_status { get; set; }
        public string call_result { get; set; }
    }
}
