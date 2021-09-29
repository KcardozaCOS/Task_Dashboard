using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgTrackedSoftwareProduct
    {
        public Guid Id { get; set; }
        public Guid TrackedSoftwareId { get; set; }
        public Guid SoftwareProductId { get; set; }

        public virtual SoftProduct SoftwareProduct { get; set; }
        public virtual TrackedSoftware TrackedSoftware { get; set; }
    }
}
