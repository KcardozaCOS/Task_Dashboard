using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgArchiveDatabase
    {
        public Guid Id { get; set; }
        public string DatabaseName { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? LogId { get; set; }

        public virtual CfgToolLog Log { get; set; }
    }
}
