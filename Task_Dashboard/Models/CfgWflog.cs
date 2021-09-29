using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWflog
    {
        public CfgWflog()
        {
            CfgWflogData = new HashSet<CfgWflogDatum>();
            CfgWflogEmails = new HashSet<CfgWflogEmail>();
        }

        public Guid Id { get; set; }
        public DateTime RunDate { get; set; }
        public Guid? ObjectId { get; set; }
        public Guid LceventId { get; set; }
        public Guid WfobjectId { get; set; }
        public int DataEvent { get; set; }
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public Guid? UserId { get; set; }
        public int? Initiator { get; set; }
        public string Host { get; set; }
        public Guid? LcactionId { get; set; }

        public virtual CfgLcevent Lcevent { get; set; }
        public virtual CfgWfobject Wfobject { get; set; }
        public virtual ICollection<CfgWflogDatum> CfgWflogData { get; set; }
        public virtual ICollection<CfgWflogEmail> CfgWflogEmails { get; set; }
    }
}
