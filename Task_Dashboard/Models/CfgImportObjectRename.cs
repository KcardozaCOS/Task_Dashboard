using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgImportObjectRename
    {
        public string TableName { get; set; }
        public int OldId { get; set; }
        public Guid NewId { get; set; }
        public bool NewObject { get; set; }
        public Guid Id { get; set; }
    }
}
