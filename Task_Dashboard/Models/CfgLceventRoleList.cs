using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLceventRoleList
    {
        public Guid LceventId { get; set; }
        public string Class { get; set; }
        public Guid Id { get; set; }
        public int Cid { get; set; }
        public Guid WfobjectId { get; set; }
        public string Kind { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public Guid SecurityRoleId { get; set; }
    }
}
