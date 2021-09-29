using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcimage
    {
        public CfgLcimage()
        {
            CfgLcevents = new HashSet<CfgLcevent>();
            Statuses = new HashSet<Status>();
            TicketPriorities = new HashSet<TicketPriority>();
        }

        public Guid Id { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<CfgLcevent> CfgLcevents { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }
        public virtual ICollection<TicketPriority> TicketPriorities { get; set; }
    }
}
