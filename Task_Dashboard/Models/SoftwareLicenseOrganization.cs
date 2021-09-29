using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareLicenseOrganization
    {
        public Guid Id { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public Guid? OrganizationId { get; set; }
        public bool IncludeSubOrganizations { get; set; }

        public virtual OrganizationalUnit Organization { get; set; }
        public virtual SoftwareLicense SoftwareLicense { get; set; }
    }
}
