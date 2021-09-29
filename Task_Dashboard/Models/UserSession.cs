using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class UserSession
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string UserIp { get; set; }
        public DateTime LastActivity { get; set; }
        public int ModuleType { get; set; }
        public string SessionKey { get; set; }
        public string TerminatedBy { get; set; }
        public DateTime LastResponse { get; set; }
        public DateTime LogonTime { get; set; }
        public string AccountPolicy { get; set; }
        public DateTime? LogoutTime { get; set; }

        public virtual UserAccount Account { get; set; }
    }
}
