using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ApprovalStage
    {
        public ApprovalStage()
        {
            ApprovalRequests = new HashSet<ApprovalRequest>();
        }

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

        public virtual UserGroup ApprovalGroup { get; set; }
        public virtual ObjectCategory Category { get; set; }
        public virtual ObjectIndex Object { get; set; }
        public virtual Person Requester { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<ApprovalRequest> ApprovalRequests { get; set; }
    }
}
