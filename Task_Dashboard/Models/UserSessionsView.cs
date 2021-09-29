using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class UserSessionsView
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string UserIp { get; set; }
        public DateTime LastActivity { get; set; }
        public DateTime LastResponse { get; set; }
        public string SessionKey { get; set; }
        public int ModuleType { get; set; }
        public string ModuleName { get; set; }
        public string Login { get; set; }
        public string SessionType { get; set; }
        public string UserFullName { get; set; }
        public DateTime LogonTime { get; set; }
        public int? Duration { get; set; }
    }
}
