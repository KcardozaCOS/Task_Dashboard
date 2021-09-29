using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ActiveDirectory
    {
        public ActiveDirectory()
        {
            CfgAdjobOptions = new HashSet<CfgAdjobOption>();
        }

        public Guid Id { get; set; }
        public string DomainName { get; set; }
        public string ServerName { get; set; }
        public int? Port { get; set; }
        public bool UseSsl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool UseForSsp { get; set; }

        public virtual ICollection<CfgAdjobOption> CfgAdjobOptions { get; set; }
    }
}
