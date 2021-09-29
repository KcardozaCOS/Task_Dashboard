using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class XxsaCfgSecurityAction
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Module { get; set; }
        public string Object { get; set; }
        public string Priv { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ActionId { get; set; }
    }
}
