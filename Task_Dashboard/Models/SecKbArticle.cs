using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecKbArticle
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
    }
}
