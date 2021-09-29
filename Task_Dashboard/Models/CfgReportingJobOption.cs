using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgReportingJobOption
    {
        public Guid Id { get; set; }
        public string ReportName { get; set; }
        public int FileType { get; set; }
        public bool SaveToFile { get; set; }
        public string FileName { get; set; }
        public string SendTo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string AdditionalParams { get; set; }
    }
}
