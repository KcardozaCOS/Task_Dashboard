using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ReportList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ReportEngine { get; set; }
        public Guid? OriginalId { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Enabled { get; set; }
    }
}
