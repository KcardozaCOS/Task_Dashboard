using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ApprovalRequestList
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public int? Rank { get; set; }
        public Guid ApprovalStageId { get; set; }
        public Guid ApproverId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string Notes { get; set; }
        public Guid? ObjectId { get; set; }
        public string Stage { get; set; }
        public string Description { get; set; }
        public string StageStatus { get; set; }
        public string Class { get; set; }
        public string AppliesTo { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Approver { get; set; }
        public string Requester { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int LinksCount { get; set; }
    }
}
