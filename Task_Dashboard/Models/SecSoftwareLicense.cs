using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecSoftwareLicense
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? TrackedSoftwareId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? LocationId { get; set; }
        public string SerialNum { get; set; }
        public string Notes { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string InstallKey { get; set; }
        public Guid? PolicyId { get; set; }
        public bool MasterLicense { get; set; }
        public int? LicenseQty { get; set; }
        public string UdfLegacyMedia { get; set; }
        public string Oid { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? UpgradeForId { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
