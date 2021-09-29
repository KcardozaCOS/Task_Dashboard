using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PoShipping
    {
        public PoShipping()
        {
            Pos = new HashSet<Po>();
        }

        public Guid Id { get; set; }
        public string Shipping { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<Po> Pos { get; set; }
    }
}
