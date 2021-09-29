using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgServiceOperation
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public string Operation { get; set; }
        public Guid LceventId { get; set; }
        public int GroupNum { get; set; }
        public int OperationNum { get; set; }
        public bool Enabled { get; set; }

        public virtual CfgJob Job { get; set; }
        public virtual CfgLcevent Lcevent { get; set; }
    }
}
