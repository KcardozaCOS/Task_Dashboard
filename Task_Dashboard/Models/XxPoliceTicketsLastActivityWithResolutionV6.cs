using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxPoliceTicketsLastActivityWithResolutionV6
    {
        public string Ticket { get; set; }
        public string Organization { get; set; }
        public string Priority { get; set; }
        public string Requester { get; set; }
        public DateTime? SubmitDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Assignee { get; set; }
        public string AssigneeGroup { get; set; }
        public string CreatedDate { get; set; }
        public string Summary { get; set; }
        public string Expr1 { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public string Resolution { get; set; }
    }
}
