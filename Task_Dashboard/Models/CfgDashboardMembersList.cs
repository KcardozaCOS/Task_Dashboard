using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDashboardMembersList
    {
        public Guid Id { get; set; }
        public Guid WidgetId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public Guid DashboardId { get; set; }
        public Guid? PanelId { get; set; }
        public string DashboardName { get; set; }
    }
}
