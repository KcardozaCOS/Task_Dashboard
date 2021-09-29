using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgEmailQueue
    {
        public CfgEmailQueue()
        {
            CfgEmailAttachments = new HashSet<CfgEmailAttachment>();
        }

        public Guid Id { get; set; }
        public DateTime QueueDate { get; set; }
        public int Initiator { get; set; }
        public int Executor { get; set; }
        public string ExecutorId { get; set; }
        public string Host { get; set; }
        public string SendFrom { get; set; }
        public string SendTo { get; set; }
        public string SendCc { get; set; }
        public string SendBcc { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int ContentType { get; set; }
        public DateTime? SendDate { get; set; }
        public string SendError { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool System { get; set; }

        public virtual ICollection<CfgEmailAttachment> CfgEmailAttachments { get; set; }
    }
}
