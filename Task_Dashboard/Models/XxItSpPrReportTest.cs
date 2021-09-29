using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxItSpPrReportTest
    {
        public string OrganizationName { get; set; }
        public string Requester { get; set; }
        public string Oid { get; set; }
        public string Type { get; set; }
        public string Project { get; set; }
        public string Manager { get; set; }
        public string Status { get; set; }
        public int? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EstimatedHours { get; set; }
        public double? TimeSpent { get; set; }
        public string TimeSpentSt { get; set; }
        public string StatusUpdate { get; set; }
        public string Description { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string AssigneeGroup { get; set; }
        public string Category { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ReqPriority { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
