using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecNetwork
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? LocationId { get; set; }
        public string IpFrom { get; set; }
        public string IpTo { get; set; }
        public string Notes { get; set; }
        public string Domain { get; set; }
        public string Ipv6From { get; set; }
        public string Ipv6To { get; set; }
    }
}
