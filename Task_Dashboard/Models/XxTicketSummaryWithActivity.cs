using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxTicketSummaryWithActivity
    {
        public Guid Id { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectTitle { get; set; }
        public double? PTimeSpentMins { get; set; }
        public string ProjectStatus { get; set; }
        public double? PTimespent { get; set; }
        public double? TTimespentMins { get; set; }
        public double? TTimespent { get; set; }
        public int? Yyyymm { get; set; }
        public string Ticket { get; set; }
        public string Organization { get; set; }
        public string Summary { get; set; }
        public string TStatus { get; set; }
        public string Requester { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string Assignee { get; set; }
        public string AssigneeGroup { get; set; }
        public string Category { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public DateTime? CompletedDate { get; set; }
        public double? CumulativeTimeSpent { get; set; }
        public string OrganizationTitle { get; set; }
        public string Project { get; set; }
        public DateTime? ACreatedDate { get; set; }
        public double? ATimespentMins { get; set; }
        public string ACreatedBy { get; set; }
    }
}
