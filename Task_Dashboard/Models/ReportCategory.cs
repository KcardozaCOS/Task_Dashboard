using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ReportCategory
    {
        public Guid Id { get; set; }
        public Guid ReportCategoryId { get; set; }
        public Guid ReportId { get; set; }
    }
}
