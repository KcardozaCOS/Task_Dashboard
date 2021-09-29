using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSecurityRoleList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Default { get; set; }
        public bool UserOuRestricted { get; set; }
        public bool OuRestricted { get; set; }
        public int? MemberCount { get; set; }
    }
}
