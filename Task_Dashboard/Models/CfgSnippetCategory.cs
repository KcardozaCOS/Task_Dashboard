using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSnippetCategory
    {
        public CfgSnippetCategory()
        {
            CfgSnippets = new HashSet<CfgSnippet>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Rank { get; set; }
        public Guid? PersonId { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<CfgSnippet> CfgSnippets { get; set; }
    }
}
