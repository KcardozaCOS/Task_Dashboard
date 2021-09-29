using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgRecurrentTicketList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ClassId { get; set; }
        public bool? Enabled { get; set; }
        public string Schedule { get; set; }
        public Guid LceventsId { get; set; }
    }
}
