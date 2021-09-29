using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgTicketsAllActive
    {
        public int TicketKind { get; set; }
        public Guid Id { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? RequesterId { get; set; }
        public Guid? ChangeRequestId { get; set; }
        public Guid? AssigneeGroupId { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? RelatedCiId { get; set; }
        public Guid? RelatedProblemId { get; set; }
    }
}
