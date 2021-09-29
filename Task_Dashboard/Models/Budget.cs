using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Budget
    {
        public Budget()
        {
            Pos = new HashSet<Po>();
        }

        public Guid Id { get; set; }
        public string Budget1 { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<Po> Pos { get; set; }
    }
}
