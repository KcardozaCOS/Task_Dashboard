using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSecurityRole
    {
        public CfgSecurityRole()
        {
            CfgLceventRoles = new HashSet<CfgLceventRole>();
            CfgSecurityRoleActions = new HashSet<CfgSecurityRoleAction>();
            CfgSecurityRoleDashboards = new HashSet<CfgSecurityRoleDashboard>();
            CfgSecurityRoleMembers = new HashSet<CfgSecurityRoleMember>();
            CfgSecurityRoleOus = new HashSet<CfgSecurityRoleOu>();
            CfgSecurityRoleViews = new HashSet<CfgSecurityRoleView>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Default { get; set; }
        public bool UserOuRestricted { get; set; }
        public bool OuRestricted { get; set; }

        public virtual ICollection<CfgLceventRole> CfgLceventRoles { get; set; }
        public virtual ICollection<CfgSecurityRoleAction> CfgSecurityRoleActions { get; set; }
        public virtual ICollection<CfgSecurityRoleDashboard> CfgSecurityRoleDashboards { get; set; }
        public virtual ICollection<CfgSecurityRoleMember> CfgSecurityRoleMembers { get; set; }
        public virtual ICollection<CfgSecurityRoleOu> CfgSecurityRoleOus { get; set; }
        public virtual ICollection<CfgSecurityRoleView> CfgSecurityRoleViews { get; set; }
    }
}
