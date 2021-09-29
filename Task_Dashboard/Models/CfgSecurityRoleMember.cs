using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSecurityRoleMember
    {
        public Guid Id { get; set; }
        public Guid SecurityRoleId { get; set; }
        public Guid OwnerId { get; set; }

        public virtual UserAccount Owner { get; set; }
        public virtual CfgSecurityRole SecurityRole { get; set; }
    }
}
