using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class UserGroupListTechnician
    {
        public Guid Id { get; set; }
        public Guid? ManagerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public bool TechniciansOnly { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Manager { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int? FlagStatus { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int TicketsCount { get; set; }
        public int MembersCount { get; set; }
        public int LinksCount { get; set; }
    }
}
