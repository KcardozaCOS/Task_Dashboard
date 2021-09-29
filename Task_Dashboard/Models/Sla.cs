using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Sla
    {
        public Sla()
        {
            Receivers = new HashSet<Receiver>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid? ServiceId { get; set; }
        public Guid? ServiceProviderId { get; set; }
        public Guid? ServiceLevelId { get; set; }
        public string Notes { get; set; }
        public string Oid { get; set; }
        public bool Global { get; set; }
        public double? UdfExpCommit { get; set; }
        public int? UdfEstEffort { get; set; }

        public virtual ObjectCategory Category { get; set; }
        public virtual Service Service { get; set; }
        public virtual ServiceLevel ServiceLevel { get; set; }
        public virtual OrganizationalUnit ServiceProvider { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<Receiver> Receivers { get; set; }
    }
}
