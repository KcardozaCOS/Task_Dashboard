using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxUltimateTicketLookupV6
    {
        public string Ticket { get; set; }
        public string Requester { get; set; }
        public string Organization { get; set; }
        public string Assignee { get; set; }
        public string AssigneeGroup { get; set; }
        public DateTime? SubmitDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime? SubmitTime { get; set; }
        public int ActivityCount { get; set; }
        public string Details { get; set; }
        public int? Num { get; set; }
        public string Type { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
