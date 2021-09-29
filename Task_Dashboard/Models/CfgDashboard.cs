using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDashboard
    {
        public CfgDashboard()
        {
            CfgDashboardMembers = new HashSet<CfgDashboardMember>();
            CfgSecurityRoleDashboards = new HashSet<CfgSecurityRoleDashboard>();
            InverseBaseDashboard = new HashSet<CfgDashboard>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public Guid? PersonId { get; set; }
        public Guid? BaseDashboardId { get; set; }

        public virtual CfgDashboard BaseDashboard { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<CfgDashboardMember> CfgDashboardMembers { get; set; }
        public virtual ICollection<CfgSecurityRoleDashboard> CfgSecurityRoleDashboards { get; set; }
        public virtual ICollection<CfgDashboard> InverseBaseDashboard { get; set; }
    }
}
