using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            CfgSecurityRoleMembers = new HashSet<CfgSecurityRoleMember>();
            CfgViewSettings = new HashSet<CfgViewSetting>();
            UserSessions = new HashSet<UserSession>();
        }

        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime? PswdLastChange { get; set; }
        public string AccountType { get; set; }
        public bool Active { get; set; }
        public string LastIp { get; set; }
        public DateTime? LastActivity { get; set; }
        public int? AccessLevel { get; set; }
        public string AccountPolicy { get; set; }
        public string PlainPassword { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<CfgSecurityRoleMember> CfgSecurityRoleMembers { get; set; }
        public virtual ICollection<CfgViewSetting> CfgViewSettings { get; set; }
        public virtual ICollection<UserSession> UserSessions { get; set; }
    }
}
