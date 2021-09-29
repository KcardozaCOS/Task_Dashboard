using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDashboardWidget
    {
        public CfgDashboardWidget()
        {
            CfgDashboardMembers = new HashSet<CfgDashboardMember>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Data { get; set; }

        public virtual ICollection<CfgDashboardMember> CfgDashboardMembers { get; set; }
    }
}
