using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ChangeRequestApprovalList
    {
        public Guid Id { get; set; }
        public int? Rank { get; set; }
        public Guid ChangeRequestId { get; set; }
        public Guid ApproverId { get; set; }
        public Guid? StatusId { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string Notes { get; set; }
        public Guid? TypeId { get; set; }
        public string Status { get; set; }
        public string Approver { get; set; }
        public string Type { get; set; }
    }
}
