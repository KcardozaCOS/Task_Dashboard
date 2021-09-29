using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSecurityRoleOu
    {
        public Guid Id { get; set; }
        public Guid SecurityRoleId { get; set; }
        public Guid OrganizationId { get; set; }

        public virtual OrganizationalUnit Organization { get; set; }
        public virtual CfgSecurityRole SecurityRole { get; set; }
    }
}
