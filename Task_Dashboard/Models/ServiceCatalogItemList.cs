using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ServiceCatalogItemList
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public Guid? RequestFulfillmentId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public decimal? Price { get; set; }
        public byte[] Picture { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public Guid? ServiceId { get; set; }
        public string Notes { get; set; }
        public string RequestFulfillment { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string ServiceName { get; set; }
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
        public int? RequestCount { get; set; }
    }
}
