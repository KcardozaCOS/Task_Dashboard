using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Hardware
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
        public string SerialNum { get; set; }
        public string Notes { get; set; }
        public DateTime? InstallDate { get; set; }
        public Guid? ManufacturerId { get; set; }
        public string Model { get; set; }
        public string Product { get; set; }
        public Guid? NetworkId { get; set; }
        public string Udf0007 { get; set; }
        public DateTime? UdfLegacyWarrantyExp { get; set; }
        public string PrimaryIpAddress { get; set; }
        public Guid? ImportId { get; set; }
        public DateTime? AuditDate { get; set; }
        public string UdfPhoneNumber { get; set; }
        public string UdfImei { get; set; }

        public virtual ObjectCategory Category { get; set; }
        public virtual Location Location { get; set; }
        public virtual Brand Manufacturer { get; set; }
        public virtual Network Network { get; set; }
        public virtual OrganizationalUnit Organization { get; set; }
        public virtual Person Owner { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
    }
}
