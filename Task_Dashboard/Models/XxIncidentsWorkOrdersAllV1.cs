using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxIncidentsWorkOrdersAllV1
    {
        public string Ticket { get; set; }
        public string Organization { get; set; }
        public int? Udf0004 { get; set; }
        public string Udf0002 { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Requester { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string Assignee { get; set; }
        public string AssigneeGroup { get; set; }
        public string Category { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
