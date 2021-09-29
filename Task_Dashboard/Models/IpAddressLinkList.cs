using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class IpAddressLinkList
    {
        public Guid Id { get; set; }
        public Guid IpAddressId { get; set; }
        public Guid ObjectId { get; set; }
        public bool Manual { get; set; }
        public bool Primary { get; set; }
        public string IpAddress { get; set; }
        public string Notes { get; set; }
        public string NetworkName { get; set; }
        public string AssetClass { get; set; }
        public string CiOid { get; set; }
    }
}
