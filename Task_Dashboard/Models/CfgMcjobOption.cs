using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgMcjobOption
    {
        public Guid Id { get; set; }
        public string Version { get; set; }
        public bool? AddEmailAsAttachment { get; set; }
        public bool? DeleteCompleted { get; set; }
        public string MailType { get; set; }
        public string MailProfile { get; set; }
        public bool? IsDefaultMailProfile { get; set; }
        public string MailServer { get; set; }
        public int? MailPort { get; set; }
        public string Mailbox { get; set; }
        public string MailUser { get; set; }
        public string MailPassword { get; set; }
        public bool? UseSpa { get; set; }
        public int? SslFlags { get; set; }
        public bool? CertificateReject { get; set; }
        public Guid? PersonConstructorId { get; set; }
        public bool? DeleteRejected { get; set; }
        public bool? MarkReadRejected { get; set; }
        public bool? MarkReadCompleted { get; set; }
        public bool? PurgeDeleted { get; set; }
        public string RunAsLogin { get; set; }
        public string RunAsPassword { get; set; }
        public string OperationGroups { get; set; }
        public string EwsAddress { get; set; }
        public string EwsUrl { get; set; }
        public bool? EwsAutodiscover { get; set; }
        public int? EwsVersion { get; set; }

        public virtual CfgLcevent PersonConstructor { get; set; }
    }
}
