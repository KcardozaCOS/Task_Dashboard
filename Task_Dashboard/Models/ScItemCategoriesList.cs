using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ScItemCategoriesList
    {
        public Guid Id { get; set; }
        public Guid ScCategoryId { get; set; }
        public Guid ScItemId { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
