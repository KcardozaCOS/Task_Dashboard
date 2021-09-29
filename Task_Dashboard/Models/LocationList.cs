using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LocationList
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? TypeId { get; set; }
        public string Location { get; set; }
        public string Placement { get; set; }
        public string Address { get; set; }
        public string TimeZone { get; set; }
        public string Notes { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public Guid? ManagerId { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Manager { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int LinksCount { get; set; }
    }
}
