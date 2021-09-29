using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxsaObjectCategoryDescendent
    {
        public Guid? RootId { get; set; }
        public Guid? CategoryId { get; set; }
        public bool? Active { get; set; }
        public string Category { get; set; }
    }
}
