using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcformField
    {
        public Guid Id { get; set; }
        public Guid FormId { get; set; }
        public string FieldCaption { get; set; }
        public int FieldType { get; set; }
        public string TableName { get; set; }
        public Guid? LookupId { get; set; }
        public string LookupValues { get; set; }

        public virtual CfgLcform Form { get; set; }
    }
}
