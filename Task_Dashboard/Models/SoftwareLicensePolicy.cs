using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareLicensePolicy
    {
        public SoftwareLicensePolicy()
        {
            SoftwareLicenses = new HashSet<SoftwareLicense>();
        }

        public Guid Id { get; set; }
        public string Policy { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public string Tags { get; set; }
        public Guid? TrackingId { get; set; }

        public virtual LicenseTrackingType Tracking { get; set; }
        public virtual ICollection<SoftwareLicense> SoftwareLicenses { get; set; }
    }
}
