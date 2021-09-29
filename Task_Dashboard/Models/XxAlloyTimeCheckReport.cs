using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxAlloyTimeCheckReport
    {
        public string Summary { get; set; }
        public string Ticket { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public double? TimeSpent { get; set; }
        public string Details { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Requester { get; set; }
        public DateTime? SubmitDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Organization { get; set; }
    }
}
