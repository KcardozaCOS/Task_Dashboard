using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class OrganizationalUnitListActive
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? CategoryId { get; set; }
        public string Name { get; set; }
        public string Placement { get; set; }
        public bool Internal { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Notes { get; set; }
        public string WebPage { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Udf0001 { get; set; }
        public string Udf0002 { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public bool Vendor { get; set; }
        public bool Customer { get; set; }
        public Guid? ManagerId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public int? PersonsCount { get; set; }
        public int? TicketsCount { get; set; }
        public int? SlaCount { get; set; }
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
