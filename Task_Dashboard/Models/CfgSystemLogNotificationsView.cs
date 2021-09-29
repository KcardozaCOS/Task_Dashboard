using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSystemLogNotificationsView
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Category { get; set; }
        public string AddressType { get; set; }
        public Guid? PersonId { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
