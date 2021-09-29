using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDashboardList
    {
        public Guid Id { get; set; }
        public string DashboardName { get; set; }
        public string Data { get; set; }
        public int RoleCount { get; set; }
    }
}
