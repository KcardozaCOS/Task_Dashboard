using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ReservationListActive
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public Guid LibraryItemId { get; set; }
        public Guid RequesterId { get; set; }
        public Guid? StatusId { get; set; }
        public DateTime? ReservationDateFrom { get; set; }
        public DateTime? ReservationDateTo { get; set; }
        public Guid? TypeId { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string Requester { get; set; }
        public string LibraryItem { get; set; }
        public string Type { get; set; }
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
