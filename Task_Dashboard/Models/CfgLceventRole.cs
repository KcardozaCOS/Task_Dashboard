using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLceventRole
    {
        public Guid Id { get; set; }
        public Guid LceventId { get; set; }
        public Guid SecurityRoleId { get; set; }

        public virtual CfgLcevent Lcevent { get; set; }
        public virtual CfgSecurityRole SecurityRole { get; set; }
    }
}
