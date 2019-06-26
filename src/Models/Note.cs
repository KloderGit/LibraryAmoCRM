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
}
