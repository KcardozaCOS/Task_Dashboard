using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcrecurrentField
    {
        public Guid Id { get; set; }
        public Guid FieldId { get; set; }
        public Guid ObjectId { get; set; }
        public string FieldValue { get; set; }

        public virtual CfgLcformDefinition Field { get; set; }
        public virtual CfgLcrecurrentObject Object { get; set; }
    }
}
