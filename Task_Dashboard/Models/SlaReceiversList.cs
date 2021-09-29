using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SlaReceiversList
    {
        public Guid Id { get; set; }
        public Guid SlaId { get; set; }
        public Guid ReceiverOrganizationId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Placement { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public bool Internal { get; set; }
        public string WebPage { get; set; }
        public string Phone { get; set; }
    }
}
