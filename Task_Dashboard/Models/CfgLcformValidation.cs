using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcformValidation
    {
        public Guid Id { get; set; }
        public Guid FormId { get; set; }
        public Guid? SectionId { get; set; }
        public string Condition { get; set; }
        public int MessageType { get; set; }
        public string MessageText { get; set; }
        public int? Rank { get; set; }

        public virtual CfgLcform Form { get; set; }
    }
}
