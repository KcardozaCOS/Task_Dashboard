using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class Gender
    {
        public Gender()
        {
            People = new HashSet<Person>();
        }

        public Guid Id { get; set; }
        public string Gender1 { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
