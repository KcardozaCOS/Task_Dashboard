using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcoperation
    {
        public CfgLcoperation()
        {
            CfgWflogData = new HashSet<CfgWflogDatum>();
        }

        public Guid Id { get; set; }
        public Guid FunctionId { get; set; }
        public int OperationNum { get; set; }
        public int OperationKind { get; set; }
        public string Definition { get; set; }
        public Guid? SubFunctionId { get; set; }
        public int GroupNum { get; set; }
        public bool Enabled { get; set; }
        public Guid? TemplateId { get; set; }
        public Guid? EmailId { get; set; }

        public virtual CfgLcemail Email { get; set; }
        public virtual CfgLcfunction Function { get; set; }
        public virtual CfgLcfunction SubFunction { get; set; }
        public virtual CfgLctemplate Template { get; set; }
        public virtual ICollection<CfgWflogDatum> CfgWflogData { get; set; }
    }
}
