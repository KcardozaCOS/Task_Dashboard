using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class KbArticle
    {
        public KbArticle()
        {
            KbArticleCategories = new HashSet<KbArticleCategory>();
            KbArticleOrganizations = new HashSet<KbArticleOrganization>();
        }

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

        public virtual Person ApprovedBy { get; set; }
        public virtual Person Author { get; set; }
        public virtual Person Owner { get; set; }
        public virtual Status Status { get; set; }
        public virtual ObjectType Type { get; set; }
        public virtual ICollection<KbArticleCategory> KbArticleCategories { get; set; }
        public virtual ICollection<KbArticleOrganization> KbArticleOrganizations { get; set; }
    }
}
