using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ScCategoryList
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public bool Public { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
    }
}
