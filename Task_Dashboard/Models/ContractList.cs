using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ContractList
    {
        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public string ContractNumber { get; set; }
        public decimal? Cost { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string WarrantyDetails { get; set; }
        public Guid? TypeId { get; set; }
        public string Oid { get; set; }
        public bool RenewalOption { get; set; }
        public Guid? ProviderId { get; set; }
        public Guid? ReceiverId { get; set; }
        public string UdfLocation { get; set; }
        public string Receiver { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Provider { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? FlagStatus { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int LinksCount { get; set; }
    }
}
