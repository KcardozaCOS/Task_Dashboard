using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Network
    {
        public Network()
        {
            Computers = new HashSet<Computer>();
            Hardwares = new HashSet<Hardware>();
            IpAddresses = new HashSet<IpAddress>();
        }

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

        public virtual ObjectCategory Category { get; set; }
        public virtual Location Location { get; set; }
        public virtual OrganizationalUnit Organization { get; set; }
        public virtual Person Owner { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<IpAddress> IpAddresses { get; set; }
    }
}
