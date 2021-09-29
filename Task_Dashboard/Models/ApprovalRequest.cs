using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ApprovalRequest
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

        public virtual ApprovalStage ApprovalStage { get; set; }
        public virtual Person Approver { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
    }
}
