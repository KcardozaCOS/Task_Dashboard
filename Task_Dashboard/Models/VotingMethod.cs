using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class VotingMethod
    {
        public VotingMethod()
        {
            ChangeRequests = new HashSet<ChangeRequest>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Rank { get; set; }

        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
    }
}
