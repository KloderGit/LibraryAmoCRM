using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Note : INote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsEditable { get; set; }
        public string Attachment { get; set; }
        public int NoteType { get; set; }
        public INoteParam Params { get; set; }
        public int ResponsibleUserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AccountId { get; set; }
        public int GroupId { get; set; }        
        public int ElementId { get; set; }
        public int ElementType { get; set; }
    }

    public class NoteParam : INoteParam
    {
        public string Text { get; set; }
        public string Service { get; set; }

        public string Sender { get; set; }
        public string Html { get; set; }

        public string Uniq { get; set; }
        public string Link { get; set; }
        public string Phone { get; set; }
        public int Duration { get; set; }
        public string From { get; set; }
        public string Src { get; set; }
        public string CallStatus { get; set; }
        public string CallResult { get; set; }
    }
}
