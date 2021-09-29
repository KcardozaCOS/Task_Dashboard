using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSystemLogNotification
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string AddressType { get; set; }
        public Guid? PersonId { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public virtual CfgSystemLogCategory Category { get; set; }
        public virtual Person Person { get; set; }
    }
}
