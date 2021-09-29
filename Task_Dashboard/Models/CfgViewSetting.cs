using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgViewSetting
    {
        public Guid Id { get; set; }
        public string ObjectName { get; set; }
        public Guid? CurrentId { get; set; }
        public int ObjectKind { get; set; }
        public Guid AccountId { get; set; }
        public Guid? ClassId { get; set; }

        public virtual UserAccount Account { get; set; }
        public virtual ObjectClass Class { get; set; }
        public virtual CfgView Current { get; set; }
    }
}
