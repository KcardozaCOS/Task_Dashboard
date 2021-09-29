using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PersonalFlag
    {
        public Guid? Id { get; set; }
        public Guid? ObjectId { get; set; }
        public int? FlagStatus { get; set; }
    }
}
