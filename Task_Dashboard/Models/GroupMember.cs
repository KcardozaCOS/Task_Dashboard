using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class GroupMember
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Guid PersonId { get; set; }
        public int? Rank { get; set; }
        public int? GroupRank { get; set; }

        public virtual UserGroup Group { get; set; }
        public virtual Person Person { get; set; }
    }
}
