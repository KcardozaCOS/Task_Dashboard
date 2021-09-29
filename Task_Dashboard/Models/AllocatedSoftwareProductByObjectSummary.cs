using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class AllocatedSoftwareProductByObjectSummary
    {
        public Guid ProductId { get; set; }
        public Guid ObjectId { get; set; }
        public int? Quantity { get; set; }
    }
}
