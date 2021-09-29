using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgInstaller
    {
        public Guid Id { get; set; }
        public byte[] Data { get; set; }
    }
}
