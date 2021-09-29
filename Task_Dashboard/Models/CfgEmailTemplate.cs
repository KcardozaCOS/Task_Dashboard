using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgEmailTemplate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Macro { get; set; }
        public bool Activity { get; set; }
        public bool Web { get; set; }
    }
}
