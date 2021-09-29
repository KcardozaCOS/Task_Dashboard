using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLicenseStaticCompliance
    {
        public Guid Id { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public bool Compliant { get; set; }
        public int Violation { get; set; }
        public int? Qty { get; set; }
        public int? Reconciled { get; set; }
        public int? Used { get; set; }
        public int? Available { get; set; }
        public int? Required { get; set; }
        public int? Allocated { get; set; }
        public int? UnreconciledAllocations { get; set; }
        public int? Upgraded { get; set; }

        public virtual SoftwareLicense SoftwareLicense { get; set; }
    }
}
