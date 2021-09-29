using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ServiceReceiversList
    {
        public Guid Id { get; set; }
        public Guid SlaId { get; set; }
        public Guid ReceiverOrganizationId { get; set; }
        public Guid? ServiceId { get; set; }
        public string SlaName { get; set; }
        public string SlaServiceName { get; set; }
        public string ReceiverName { get; set; }
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
