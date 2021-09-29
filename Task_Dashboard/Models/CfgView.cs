using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgView
    {
        public CfgView()
        {
            CfgDisabledViews = new HashSet<CfgDisabledView>();
            CfgSecurityRoleViews = new HashSet<CfgSecurityRoleView>();
            CfgViewSettings = new HashSet<CfgViewSetting>();
        }

        public Guid Id { get; set; }
        public Guid? PersonId { get; set; }
        public string ObjectName { get; set; }
        public string Name { get; set; }
        public string View { get; set; }
        public bool Shared { get; set; }
        public bool IsAdmin { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<CfgDisabledView> CfgDisabledViews { get; set; }
        public virtual ICollection<CfgSecurityRoleView> CfgSecurityRoleViews { get; set; }
        public virtual ICollection<CfgViewSetting> CfgViewSettings { get; set; }
    }
}
