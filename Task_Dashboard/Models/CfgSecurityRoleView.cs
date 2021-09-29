using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSecurityRoleView
    {
        public Guid Id { get; set; }
        public Guid SecurityRoleId { get; set; }
        public Guid ViewId { get; set; }

        public virtual CfgSecurityRole SecurityRole { get; set; }
        public virtual CfgView View { get; set; }
    }
}
