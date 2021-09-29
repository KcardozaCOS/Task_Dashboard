using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareLicenseComputer
    {
        public Guid Id { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public string ComputerName { get; set; }

        public virtual SoftwareLicense SoftwareLicense { get; set; }
    }
}
