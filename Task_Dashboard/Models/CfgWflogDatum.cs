using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWflogDatum
    {
        public Guid Id { get; set; }
        public Guid LogId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid OperationId { get; set; }
        public int? OperationKind { get; set; }
        public string OperationParams { get; set; }
        public int? OrderIndex { get; set; }

        public virtual CfgWflog Log { get; set; }
        public virtual CfgLcoperation Operation { get; set; }
    }
}
