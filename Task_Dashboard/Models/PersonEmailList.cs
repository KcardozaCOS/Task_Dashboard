using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PersonEmailList
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public Guid? TypeId { get; set; }
        public string Email { get; set; }
        public bool Primary { get; set; }
        public string EmailType { get; set; }
    }
}
