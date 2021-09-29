using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LicenseTrackingType
    {
        public LicenseTrackingType()
        {
            SoftwareLicensePolicies = new HashSet<SoftwareLicensePolicy>();
        }

        public Guid Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SoftwareLicensePolicy> SoftwareLicensePolicies { get; set; }
    }
}
