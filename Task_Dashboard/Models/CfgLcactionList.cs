using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcactionList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public int Cid { get; set; }
        public string Kind { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public string FormName { get; set; }
        public bool Enabled { get; set; }
    }
}
