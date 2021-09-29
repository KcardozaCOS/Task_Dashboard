using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgJobList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int JobType { get; set; }
        public int LogLevel { get; set; }
        public bool Enabled { get; set; }
        public bool RunAsap { get; set; }
        public string RunAsLogin { get; set; }
        public string RunAsPassword { get; set; }
    }
}
