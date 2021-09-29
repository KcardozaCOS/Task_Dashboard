using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class TicketsByRelatedCiSummary
    {
        public Guid? RelatedCiId { get; set; }
        public int? Count { get; set; }
    }
}
