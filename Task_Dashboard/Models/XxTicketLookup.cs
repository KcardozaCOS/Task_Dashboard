using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxTicketLookup
    {
        public DateTime? CreatedDate { get; set; }
        public string Details { get; set; }
        public int? Num { get; set; }
        public Guid ObjectId { get; set; }
    }
}
