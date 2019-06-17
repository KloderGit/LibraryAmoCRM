using LibraryAmoCRM.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Models
{
    public class SimpleObject : ISimpleObject
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
