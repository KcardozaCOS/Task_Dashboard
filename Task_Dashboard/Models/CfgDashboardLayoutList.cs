using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDashboardLayoutList
    {
        public Guid Id { get; set; }
        public string LayoutName { get; set; }
        public string Data { get; set; }
        public string LayoutImage { get; set; }
        public int? Rank { get; set; }
    }
}
