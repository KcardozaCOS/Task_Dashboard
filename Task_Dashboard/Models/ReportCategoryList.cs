using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ReportCategoryList
    {
        public Guid Id { get; set; }
        public Guid ReportCategoryId { get; set; }
        public Guid ReportId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
    }
}
