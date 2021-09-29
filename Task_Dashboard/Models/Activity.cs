using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Activity
    {
        public Activity()
        {
            ObjectAttachments = new HashSet<ObjectAttachment>();
        }

        public Guid Id { get; set; }
        public int? Num { get; set; }
        public Guid? CreatedById { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public double? TimeSpent { get; set; }
        public string Details { get; set; }
        public bool Published { get; set; }
        public Guid ObjectId { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public string Activity1 { get; set; }
        public string WfItemNum { get; set; }
        public Guid? CategoryId { get; set; }
        public string WfActionNum { get; set; }
        public string UdfProject { get; set; }
        public DateTime? UdfActivityDate { get; set; }
        public string UdfTask { get; set; }

        public virtual ObjectCategory Category { get; set; }
        public virtual ObjectIndex Object { get; set; }
        public virtual ICollection<ObjectAttachment> ObjectAttachments { get; set; }
    }
}
