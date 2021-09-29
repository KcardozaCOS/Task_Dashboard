using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class IpAddress
    {
        public IpAddress()
        {
            IpAddressLinks = new HashSet<IpAddressLink>();
        }

        public Guid Id { get; set; }
        public Guid? NetworkId { get; set; }
        public string IpAddress1 { get; set; }
        public string Notes { get; set; }

        public virtual Network Network { get; set; }
        public virtual ICollection<IpAddressLink> IpAddressLinks { get; set; }
    }
}
