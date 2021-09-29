using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSetting
    {
        public Guid Id { get; set; }
        public Guid? PersonId { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual Person Person { get; set; }
    }
}
