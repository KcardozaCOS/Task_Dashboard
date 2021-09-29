using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgImportOid
    {
        public string TableName { get; set; }
        public int Oid { get; set; }
        public Guid Id { get; set; }
        public int OldId { get; set; }
    }
}
