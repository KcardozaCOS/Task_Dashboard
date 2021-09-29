using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SlaList
    {
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
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string ServiceProviderOrganization { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public string ServiceCategory { get; set; }
        public string ServiceStatus { get; set; }
        public string ServiceManager { get; set; }
        public string ServiceSupportGroup { get; set; }
        public string ServiceAvailabilityHours { get; set; }
        public string ServiceLevel { get; set; }
        public string SupportHours { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int LinksCount { get; set; }
    }
}
