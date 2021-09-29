using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ServiceList
    {
        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Name { get; set; }
        public Guid? ServiceManagerId { get; set; }
        public Guid? SupportGroupId { get; set; }
        public string Notes { get; set; }
        public string Oid { get; set; }
        public Guid TicketClassId { get; set; }
        public string Description { get; set; }
        public Guid? ServiceProviderId { get; set; }
        public Guid? AvailabilityHoursId { get; set; }
        public int? UdfEstEffort { get; set; }
        public double? UdfExpCommit { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string ServiceManager { get; set; }
        public string SupportGroup { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string TicketClass { get; set; }
        public string ServiceProvider { get; set; }
        public string AvailabilityHours { get; set; }
        public int LinksCount { get; set; }
    }
}
