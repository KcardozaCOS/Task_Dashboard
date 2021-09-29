using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftProductSummary
    {
        public Guid Id { get; set; }
        public Guid? TrackedSoftwareId { get; set; }
        public int Discovered { get; set; }
        public int? Used { get; set; }
    }
}
