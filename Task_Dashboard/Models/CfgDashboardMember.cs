using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDashboardMember
    {
        public Guid Id { get; set; }
        public Guid DashboardId { get; set; }
        public Guid WidgetId { get; set; }
        public Guid? PanelId { get; set; }

        public virtual CfgDashboard Dashboard { get; set; }
        public virtual CfgDashboardWidget Widget { get; set; }
    }
}
