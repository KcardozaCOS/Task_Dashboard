using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class UserSessionLog
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string UserFullName { get; set; }
        public string UserIp { get; set; }
        public int ModuleType { get; set; }
        public DateTime LogonTime { get; set; }
        public string AccountPolicy { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string TerminationReason { get; set; }
        public int ConcurrentSessionCount { get; set; }
        public int NamedSessionCount { get; set; }
    }
}
