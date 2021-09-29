using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class IpAddressList
    {
        public Guid Id { get; set; }
        public Guid? NetworkId { get; set; }
        public string IpAddress { get; set; }
        public string Notes { get; set; }
        public string NetworkName { get; set; }
        public int? Links { get; set; }
    }
}
