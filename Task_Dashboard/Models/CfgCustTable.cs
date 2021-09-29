using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgCustTable
    {
        public CfgCustTable()
        {
            CfgCustFieldLocations = new HashSet<CfgCustFieldLocation>();
            CfgCustTableFieldRefTables = new HashSet<CfgCustTableField>();
            CfgCustTableFieldTables = new HashSet<CfgCustTableField>();
        }

        public Guid Id { get; set; }
        public string TableName { get; set; }
        public string TableXType { get; set; }
        public string DisplayFields { get; set; }

        public virtual ICollection<CfgCustFieldLocation> CfgCustFieldLocations { get; set; }
        public virtual ICollection<CfgCustTableField> CfgCustTableFieldRefTables { get; set; }
        public virtual ICollection<CfgCustTableField> CfgCustTableFieldTables { get; set; }
    }
}
