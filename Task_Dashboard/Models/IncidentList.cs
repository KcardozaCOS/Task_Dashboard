using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class IncidentList
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
        public string Description { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string Summary { get; set; }
        public Guid? RelatedCiId { get; set; }
        public Guid? RelatedProblemId { get; set; }
        public DateTime? ResponseDate { get; set; }
        public Guid? MediumId { get; set; }
        public Guid? ChangeRequestId { get; set; }
        public double? CumulativeTimeSpent { get; set; }
        public double? TimeSpent { get; set; }
        public string Udf0002 { get; set; }
        public string Resolution { get; set; }
        public string Notes { get; set; }
        public Guid? ServiceId { get; set; }
        public bool UdfPrioritySetManually { get; set; }
        public bool RatingEnabled { get; set; }
        public string UdfProject { get; set; }
        public string UdfProjectCode { get; set; }
        public string UdfTask { get; set; }
        public string UdfTaskCode { get; set; }
        public DateTime? ActualResponseDate { get; set; }
        public bool Escalated { get; set; }
        public bool FirstTimeResolved { get; set; }
        public bool ResponseOverdue { get; set; }
        public bool ResolutionOverdue { get; set; }
        public bool Reopened { get; set; }
        public int? ResolutionTime { get; set; }
        public int? ResponseTime { get; set; }
        public int? UdfCustRank { get; set; }
        public double? UdfExpCommit { get; set; }
        public int? UdfEstEffort { get; set; }
        public int? UdfTechRank { get; set; }
        public string Assignee { get; set; }
        public string AssigneeGroup { get; set; }
        public string Organization { get; set; }
        public string Requester { get; set; }
        public string RequesterPhone { get; set; }
        public string RequesterLocation { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Impact { get; set; }
        public string ClosureCode { get; set; }
        public string Urgency { get; set; }
        public string Priority { get; set; }
        public string Project { get; set; }
        public string RelatedCiName { get; set; }
        public string RelatedProblemTicket { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? FlagStatus { get; set; }
        public int ActivityCount { get; set; }
        public string Medium { get; set; }
        public string ChangeRequest { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int WorkOrderCount { get; set; }
        public int RelatedObjectsCount { get; set; }
        public string ServiceName { get; set; }
        public int LinksCount { get; set; }
        public double? Rating { get; set; }
        public string RatingComment { get; set; }
    }
}
