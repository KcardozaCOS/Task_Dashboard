using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareLicense
    {
        public SoftwareLicense()
        {
            InverseUpgradeFor = new HashSet<SoftwareLicense>();
            LicenseAllocations = new HashSet<LicenseAllocation>();
            SoftwareLicenseComputers = new HashSet<SoftwareLicenseComputer>();
            SoftwareLicenseLocations = new HashSet<SoftwareLicenseLocation>();
            SoftwareLicenseOrganizations = new HashSet<SoftwareLicenseOrganization>();
        }

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

        public virtual ObjectCategory Category { get; set; }
        public virtual Location Location { get; set; }
        public virtual OrganizationalUnit Organization { get; set; }
        public virtual Person Owner { get; set; }
        public virtual SoftwareLicensePolicy Policy { get; set; }
        public virtual Status Status { get; set; }
        public virtual TrackedSoftware TrackedSoftware { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual SoftwareLicense UpgradeFor { get; set; }
        public virtual CfgLicenseStaticCompliance CfgLicenseStaticCompliance { get; set; }
        public virtual ICollection<SoftwareLicense> InverseUpgradeFor { get; set; }
        public virtual ICollection<LicenseAllocation> LicenseAllocations { get; set; }
        public virtual ICollection<SoftwareLicenseComputer> SoftwareLicenseComputers { get; set; }
        public virtual ICollection<SoftwareLicenseLocation> SoftwareLicenseLocations { get; set; }
        public virtual ICollection<SoftwareLicenseOrganization> SoftwareLicenseOrganizations { get; set; }
    }
}
