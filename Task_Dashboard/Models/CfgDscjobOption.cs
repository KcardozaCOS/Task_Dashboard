using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDscjobOption
    {
        public Guid Id { get; set; }
        public string Server { get; set; }
        public string DataBase { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Ntauth { get; set; }
        public Guid? ComputerConstructorId { get; set; }
        public Guid? ComputerTaskId { get; set; }
        public Guid? PersonConstructorId { get; set; }
        public Guid? OuConstructorId { get; set; }
        public Guid? LocationConstructorId { get; set; }
        public Guid? HardwareConstructorId { get; set; }
        public Guid? HardwareTaskId { get; set; }
        public int RetiredAction { get; set; }
        public DateTime? ProductsLastSync { get; set; }

        public virtual CfgLcevent ComputerConstructor { get; set; }
        public virtual CfgLcevent ComputerTask { get; set; }
        public virtual CfgLcevent HardwareConstructor { get; set; }
        public virtual CfgLcevent HardwareTask { get; set; }
        public virtual CfgLcevent LocationConstructor { get; set; }
        public virtual CfgLcevent OuConstructor { get; set; }
        public virtual CfgLcevent PersonConstructor { get; set; }
    }
}
