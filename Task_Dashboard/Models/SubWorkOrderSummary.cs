using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SubWorkOrderSummary
    {
        public Guid? ParentId { get; set; }
        public int? Count { get; set; }
    }
}
