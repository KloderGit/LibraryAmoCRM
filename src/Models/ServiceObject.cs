using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class ServiceObject : IToDoObject
    {
        public string Text { get; set; }
        public int Id { get; set; }
    }
}
