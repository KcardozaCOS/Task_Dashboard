using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectFlag
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public Guid PersonId { get; set; }
        public int? FlagStatus { get; set; }

        public virtual ObjectIndex Object { get; set; }
        public virtual Person Person { get; set; }
    }
}
