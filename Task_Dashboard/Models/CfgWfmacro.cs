using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWfmacro
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public Guid? WfobjectId { get; set; }
        public string Type { get; set; }
        public bool System { get; set; }

        public virtual CfgWfobject Wfobject { get; set; }
    }
}
