using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LicenseAllocationListByObject
    {
        public Guid Id { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime? AllocationDate { get; set; }
        public bool AutoDeallocate { get; set; }
        public bool AutoAdded { get; set; }
        public string Name { get; set; }
        public string TrackedSoftware { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string Policy { get; set; }
        public string SerialNum { get; set; }
        public string InstallKey { get; set; }
        public bool MasterLicense { get; set; }
        public int? LicenseQty { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? FlagStatus { get; set; }
        public int? Used { get; set; }
        public string Conformance { get; set; }
        public string Reconciled { get; set; }
    }
}
