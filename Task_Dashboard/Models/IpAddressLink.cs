using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class IpAddressLink
    {
        public Guid Id { get; set; }
        public Guid IpAddressId { get; set; }
        public Guid ObjectId { get; set; }
        public bool Manual { get; set; }
        public bool Primary { get; set; }

        public virtual IpAddress IpAddress { get; set; }
        public virtual ObjectIndex Object { get; set; }
    }
}
