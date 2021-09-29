using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class KbCategoryArticlesList
    {
        public Guid Id { get; set; }
        public Guid KbCategoryId { get; set; }
        public Guid KbArticleId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool Public { get; set; }
    }
}
