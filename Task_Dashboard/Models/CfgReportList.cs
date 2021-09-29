using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgReportList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ReportEngine { get; set; }
        public string Category { get; set; }
    }
}
