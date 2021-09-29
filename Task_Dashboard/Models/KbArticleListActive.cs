using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class KbArticleListActive
    {
        public Guid Id { get; set; }
        public Guid? StatusId { get; set; }
        public string Oid { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public bool Public { get; set; }
        public string Content { get; set; }
        public string ContentText { get; set; }
        public Guid? TypeId { get; set; }
        public string Notes { get; set; }
        public Guid? AuthorId { get; set; }
        public Guid? ApprovedById { get; set; }
        public int? Views { get; set; }
        public bool SharedWithEveryone { get; set; }
        public Guid? OwnerId { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
        public string ApprovedBy { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Owner { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Attachments { get; set; }
        public int AttachmentsCount { get; set; }
        public int AttachmentsTotalSize { get; set; }
        public int ActivityCount { get; set; }
        public int LinksCount { get; set; }
        public int? FlagStatus { get; set; }
        public double? Rating { get; set; }
        public int Votes { get; set; }
    }
}
