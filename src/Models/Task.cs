using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class Task : ITask
    {
        public bool IsCompleted { get; set; }
        public DateTime CompleteTillAt { get; set; }
        public IToDoObject Result { get; set; }
        public int TaskType { get; set; }
        public int ResponsibleUserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AccountId { get; set; }
        public int GroupId { get; set; }
        public string Text { get; set; }
        public int Id { get; set; }
        public int ElementId { get; set; }
        public int ElementType { get; set; }
    }
}
