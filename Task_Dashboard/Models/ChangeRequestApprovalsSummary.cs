using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ChangeRequestApprovalsSummary
    {
        public Guid ChangeRequestId { get; set; }
        public int? ApproverCount { get; set; }
        public int? ApprovalVotes { get; set; }
        public int? RejectionVotes { get; set; }
    }
}
