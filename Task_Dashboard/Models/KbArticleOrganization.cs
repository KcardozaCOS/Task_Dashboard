using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class KbArticleOrganization
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid KbArticleId { get; set; }

        public virtual KbArticle KbArticle { get; set; }
        public virtual OrganizationalUnit Organization { get; set; }
    }
}
