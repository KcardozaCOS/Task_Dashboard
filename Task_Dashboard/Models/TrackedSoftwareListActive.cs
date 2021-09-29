using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class TrackedSoftwareListActive
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
        public string Notes { get; set; }
        public string Owner { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? FlagStatus { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int TicketCount { get; set; }
        public string Conformance { get; set; }
        public int Discovered { get; set; }
        public int TotalLicenseQty { get; set; }
        public int Allocated { get; set; }
        public int Reconciled { get; set; }
        public int? UnreconciledInstallations { get; set; }
        public int Upgraded { get; set; }
        public int Used { get; set; }
        public int Available { get; set; }
        public int? Required { get; set; }
        public int IsTracked { get; set; }
        public int LicensesCount { get; set; }
        public int LinksCount { get; set; }
        public int NonAllocated { get; set; }
    }
}
