using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcserviceFieldMapping
    {
        public Guid Id { get; set; }
        public Guid LceventId { get; set; }
        public string FieldName { get; set; }
        public int FieldType { get; set; }
        public string FieldValue { get; set; }
        public Guid? LookupId { get; set; }
        public int ReplacementMode { get; set; }

        public virtual CfgLcevent Lcevent { get; set; }
    }
}
