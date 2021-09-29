using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSecurityDashboardList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public Guid? PersonId { get; set; }
        public Guid? BaseDashboardId { get; set; }
    }
}
