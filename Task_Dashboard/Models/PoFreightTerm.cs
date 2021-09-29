using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PoFreightTerm
    {
        public PoFreightTerm()
        {
            Pos = new HashSet<Po>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool System { get; set; }
        public bool Active { get; set; }
        public int? Rank { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<Po> Pos { get; set; }
    }
}
