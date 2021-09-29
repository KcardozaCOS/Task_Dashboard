using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSecurityRoleDashboard
    {
        public Guid Id { get; set; }
        public Guid SecurityRoleId { get; set; }
        public Guid DashboardId { get; set; }

        public virtual CfgDashboard Dashboard { get; set; }
        public virtual CfgSecurityRole SecurityRole { get; set; }
    }
}
