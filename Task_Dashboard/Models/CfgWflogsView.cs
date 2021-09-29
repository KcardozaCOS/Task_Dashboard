using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgWflogsView
    {
        public Guid Id { get; set; }
        public string EventName { get; set; }
        public int EventId { get; set; }
        public int EventKind { get; set; }
        public int? ActionId { get; set; }
        public string ActionName { get; set; }
        public Guid WfobjectId { get; set; }
        public string Class { get; set; }
        public string Oid { get; set; }
        public DateTime RunDate { get; set; }
        public int ResultCode { get; set; }
        public string Status { get; set; }
        public string ResultMessage { get; set; }
        public int DataEvent { get; set; }
        public string Event { get; set; }
        public string InitiatorName { get; set; }
        public int? Initiator { get; set; }
        public string InitiatorType { get; set; }
        public bool? Interactive { get; set; }
        public string Host { get; set; }
    }
}
