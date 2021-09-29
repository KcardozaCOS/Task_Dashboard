using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecApprovalStage
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
    }
}
