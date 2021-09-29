using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgCustFieldValue
    {
        public Guid Id { get; set; }
        public Guid FieldId { get; set; }
        public string FieldValue { get; set; }
        public int? Rank { get; set; }
        public string Tags { get; set; }

        public virtual CfgCustField Field { get; set; }
    }
}
