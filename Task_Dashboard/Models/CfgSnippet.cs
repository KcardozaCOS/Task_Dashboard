using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgSnippet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public Guid? PersonId { get; set; }
        public Guid? CategoryId { get; set; }

        public virtual CfgSnippetCategory Category { get; set; }
        public virtual Person Person { get; set; }
    }
}
