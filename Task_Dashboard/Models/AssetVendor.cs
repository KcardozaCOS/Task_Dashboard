using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class AssetVendor
    {
        public Guid Id { get; set; }
        public Guid? VendorId { get; set; }
    }
}
