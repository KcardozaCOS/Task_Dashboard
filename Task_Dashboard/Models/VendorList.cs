using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class VendorList
    {
        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string WebPage { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Fein { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public string Contact { get; set; }
        public bool Preferred { get; set; }
        public Guid? ManagerId { get; set; }
        public string Udf0001 { get; set; }
        public string Udf0002 { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Manager { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int LinksCount { get; set; }
        public int? FlagStatus { get; set; }
    }
}
