using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxIncidentWorkorderActivityListWithNotesV1
    {
        public string Summary { get; set; }
        public string Ticket { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public double? TimeSpent { get; set; }
        public string Details { get; set; }
        public string Requester { get; set; }
        public string Organization { get; set; }
        public string Assignee { get; set; }
        public string AssigneeGroup { get; set; }
        public DateTime? SubmitDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime? SubmitTime { get; set; }
        public int ActivityCount { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
    }
}
