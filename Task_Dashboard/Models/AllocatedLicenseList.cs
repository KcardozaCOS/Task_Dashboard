using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class AllocatedLicenseList
    {
        public Guid Id { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime? AllocationDate { get; set; }
        public bool AutoDeallocate { get; set; }
        public bool AutoAdded { get; set; }
        public Guid? TrackedSoftwareId { get; set; }
        public string Name { get; set; }
        public bool MasterLicense { get; set; }
        public int? LicenseQty { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Conformance { get; set; }
        public string AllocatedTo { get; set; }
        public string Class { get; set; }
        public string Oid { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }
        public string Reconciled { get; set; }
    }
}
