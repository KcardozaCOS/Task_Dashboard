using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ConfigurationList
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
        public Guid? AssociatedCiId { get; set; }
        public string Notes { get; set; }
        public string UdfSupportGroup { get; set; }
        public string UdfShortName { get; set; }
        public string UdfXmlData { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Owner { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string AssociatedCi { get; set; }
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
        public int LinksCount { get; set; }
    }
}
