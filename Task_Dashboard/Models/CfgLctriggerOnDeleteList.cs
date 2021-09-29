using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLctriggerOnDeleteList
    {
        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public bool System { get; set; }
        public bool Enabled { get; set; }
        public int? ProcessCount { get; set; }
    }
}
