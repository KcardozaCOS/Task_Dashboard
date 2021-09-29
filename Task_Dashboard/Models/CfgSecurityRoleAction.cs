using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSecurityRoleAction
    {
        public Guid Id { get; set; }
        public Guid SecurityRoleId { get; set; }
        public int ActionId { get; set; }

        public virtual CfgSecurityRole SecurityRole { get; set; }
    }
}
