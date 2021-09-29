using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareLicenseLocation
    {
        public Guid Id { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public Guid? LocationId { get; set; }
        public bool IncludeSubLocations { get; set; }

        public virtual Location Location { get; set; }
        public virtual SoftwareLicense SoftwareLicense { get; set; }
    }
}
