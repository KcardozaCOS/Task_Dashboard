using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSystemLogCategory
    {
        public CfgSystemLogCategory()
        {
            CfgSystemLogNotifications = new HashSet<CfgSystemLogNotification>();
            CfgSystemLogs = new HashSet<CfgSystemLog>();
        }

        public Guid Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<CfgSystemLogNotification> CfgSystemLogNotifications { get; set; }
        public virtual ICollection<CfgSystemLog> CfgSystemLogs { get; set; }
    }
}
