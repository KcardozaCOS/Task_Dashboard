using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SolutionRating
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public Guid PersonId { get; set; }
        public int? Rating { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ObjectIndex Object { get; set; }
        public virtual Person Person { get; set; }
    }
}
