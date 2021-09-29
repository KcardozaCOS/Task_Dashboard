using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ApprovalStageList
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public Guid? ObjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? CategoryId { get; set; }
        public string Notes { get; set; }
        public DateTime? ApprovalStartTime { get; set; }
        public DateTime? ApprovalDeadline { get; set; }
        public int? SingleVoteTimeframe { get; set; }
        public int? MinimumVotePercentage { get; set; }
        public Guid? RequesterId { get; set; }
        public Guid? ApprovalGroupId { get; set; }
        public int? Rank { get; set; }
        public string Object { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Requester { get; set; }
        public string ApprovalGroup { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int LinksCount { get; set; }
    }
}
