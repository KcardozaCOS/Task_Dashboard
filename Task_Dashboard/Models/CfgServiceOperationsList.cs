using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgServiceOperationsList
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid LceventId { get; set; }
        public string Operation { get; set; }
        public bool Enabled { get; set; }
        public int GroupNum { get; set; }
        public int OperationNum { get; set; }
        public string LceventName { get; set; }
    }
}
