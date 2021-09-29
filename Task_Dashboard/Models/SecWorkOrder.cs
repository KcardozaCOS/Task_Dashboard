using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecWorkOrder
    {
        public Guid Id { get; set; }
        public Guid? AssigneeId { get; set; }
        public Guid? AssigneeGroupId { get; set; }
        public Guid? RequesterId { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public string Ticket { get; set; }
        public Guid? ImpactId { get; set; }
        public Guid? ClosureCodeId { get; set; }
        public Guid? UrgencyId { get; set; }
        public Guid? PriorityId { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? ParentId { get; set; }
        public string Description { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string Summary { get; set; }
        public Guid? RelatedCiId { get; set; }
        public DateTime? ResponseDate { get; set; }
        public Guid? MediumId { get; set; }
        public double? CumulativeTimeSpent { get; set; }
        public double? TimeSpent { get; set; }
        public string Udf0002 { get; set; }
        public Guid? ServiceId { get; set; }
        public string Notes { get; set; }
        public bool UdfPrioritySetManually { get; set; }
        public string Resolution { get; set; }
        public bool RatingEnabled { get; set; }
        public string UdfProject { get; set; }
        public string UdfProjectCode { get; set; }
        public string UdfTask { get; set; }
        public string UdfTaskCode { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime? ActualResponseDate { get; set; }
        public int? UdfCustRank { get; set; }
        public int? UdfEstEffort { get; set; }
        public double? UdfExpCommit { get; set; }
        public int? UdfTechRank { get; set; }
    }
}
