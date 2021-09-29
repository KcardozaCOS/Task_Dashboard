using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class KbArticleCategory
    {
        public Guid Id { get; set; }
        public Guid KbCategoryId { get; set; }
        public Guid KbArticleId { get; set; }

        public virtual KbArticle KbArticle { get; set; }
        public virtual KbCategory KbCategory { get; set; }
    }
}
