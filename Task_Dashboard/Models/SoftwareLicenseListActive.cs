using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareLicenseListActive
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
        public string TrackedSoftware { get; set; }
        public string Owner { get; set; }
        public string Organization { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Policy { get; set; }
        public Guid? TrackingId { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int TicketCount { get; set; }
        public string Conformance { get; set; }
        public int? Allocated { get; set; }
        public int? Reconciled { get; set; }
        public int? UnreconciledAllocations { get; set; }
        public int? Upgraded { get; set; }
        public int? Used { get; set; }
        public int? Available { get; set; }
        public int? Required { get; set; }
        public string UpgradeFor { get; set; }
        public Guid? AssetId { get; set; }
        public string Asset { get; set; }
        public bool? Lease { get; set; }
        public DateTime? LeaseReturnDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string DepreciationMethod { get; set; }
        public DateTime? LastDepreciation { get; set; }
        public decimal? SalvageValue { get; set; }
        public int? Lifespan { get; set; }
        public decimal? CurrentValue { get; set; }
        public string PurchaseOrder { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string AssetTag { get; set; }
        public string Barcode { get; set; }
        public decimal? Price { get; set; }
        public decimal? UnitCost { get; set; }
        public int? Qty { get; set; }
        public DateTime? WarrantyExp { get; set; }
        public Guid? VendorId { get; set; }
        public string Sku { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? RetirementDate { get; set; }
        public string Vendor { get; set; }
    }
}
