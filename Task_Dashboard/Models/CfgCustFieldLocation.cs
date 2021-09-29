using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgCustFieldLocation
    {
        public Guid Id { get; set; }
        public string LocationName { get; set; }
        public int LocationIndex { get; set; }
        public Guid TableId { get; set; }

        public virtual CfgCustTable Table { get; set; }
    }
}
