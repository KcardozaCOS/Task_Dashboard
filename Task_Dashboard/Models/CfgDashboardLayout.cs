using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDashboardLayout
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public string LayoutImage { get; set; }
        public int? Rank { get; set; }
    }
}
