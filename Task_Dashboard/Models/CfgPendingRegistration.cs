using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgPendingRegistration
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string PrimaryEmail { get; set; }
        public string ActionData { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
