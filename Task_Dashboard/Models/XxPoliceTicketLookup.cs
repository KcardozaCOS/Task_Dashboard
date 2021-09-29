using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxPoliceTicketLookup
    {
        public int? Num { get; set; }
        public string Ticket { get; set; }
        public Guid ObjectId { get; set; }
        public string Resolution { get; set; }
    }
}
