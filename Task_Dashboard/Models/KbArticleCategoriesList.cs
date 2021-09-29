using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class KbArticleCategoriesList
    {
        public Guid Id { get; set; }
        public Guid KbCategoryId { get; set; }
        public Guid KbArticleId { get; set; }
        public string Oid { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public bool Public { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
