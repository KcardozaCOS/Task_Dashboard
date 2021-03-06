using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class DiscoveredInstallationList
    {
        public Guid Id { get; set; }
        public Guid SoftProductId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime? InstallDate { get; set; }
        public string InstallKey { get; set; }
        public string SerialNum { get; set; }
        public DateTime? FirstAudit { get; set; }
        public DateTime? LastAudit { get; set; }
        public Guid? TrackedSoftwareId { get; set; }
        public string PartOfSuite { get; set; }
        public string ProductName { get; set; }
        public string Version { get; set; }
        public string Manufacturer { get; set; }
        public string InstalledOn { get; set; }
        public string Oid { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }
        public string LicenseAllocated { get; set; }
    }
}
