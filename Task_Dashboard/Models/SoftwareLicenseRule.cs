using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SoftwareLicenseRule
    {
        public Guid Id { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public Guid? ObjectId { get; set; }
        public string Rule { get; set; }
        public int RuleType { get; set; }
        public string Description { get; set; }
    }
}
