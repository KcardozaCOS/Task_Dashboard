using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDashboardWidgetsList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public int? DashboardsCount { get; set; }
        public int IsDefault { get; set; }
    }
}
