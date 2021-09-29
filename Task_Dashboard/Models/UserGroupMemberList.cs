using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class UserGroupMemberList
    {
        public Guid? Id { get; set; }
        public Guid? GroupMemberId { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? PersonId { get; set; }
        public int? Rank { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Manager { get; set; }
    }
}
