using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PersonEmail
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public Guid? TypeId { get; set; }
        public string Email { get; set; }
        public bool Primary { get; set; }

        public virtual Person Person { get; set; }
        public virtual EmailType Type { get; set; }
    }
}
