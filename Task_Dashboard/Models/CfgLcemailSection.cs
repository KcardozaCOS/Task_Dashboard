using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcemailSection
    {
        public Guid Id { get; set; }
        public Guid SectionId { get; set; }
        public Guid EmailId { get; set; }
        public bool IsHtml { get; set; }
        public string Value { get; set; }

        public virtual CfgLcemail Email { get; set; }
    }
}
