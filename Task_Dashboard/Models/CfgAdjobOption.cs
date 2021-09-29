using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgAdjobOption
    {
        public Guid Id { get; set; }
        public string Domain { get; set; }
        public string From { get; set; }
        public string LdapPath { get; set; }
        public string Version { get; set; }
        public bool? Web { get; set; }
        public bool? EmptyEmail { get; set; }
        public bool? EmptyOffice { get; set; }
        public bool? UpperCaseName { get; set; }
        public Guid? PersonConstructorId { get; set; }
        public Guid? PersonTaskId { get; set; }
        public Guid? OuConstructorId { get; set; }
        public Guid? LocationConstructorId { get; set; }
        public string RunAsLogin { get; set; }
        public string RunAsPassword { get; set; }
        public bool CheckDisabledAccounts { get; set; }
        public Guid? ActiveDirectoryId { get; set; }

        public virtual ActiveDirectory ActiveDirectory { get; set; }
        public virtual CfgLcevent LocationConstructor { get; set; }
        public virtual CfgLcevent OuConstructor { get; set; }
        public virtual CfgLcevent PersonConstructor { get; set; }
        public virtual CfgLcevent PersonTask { get; set; }
    }
}
