using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class HistoryList
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public Guid? RefObjectId { get; set; }
        public string ChangedBy { get; set; }
        public Guid? ChangedById { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string Action { get; set; }
        public string Attribute { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
        public string WfItemNum { get; set; }
        public string WfActionNum { get; set; }
        public string FieldName { get; set; }
    }
}
