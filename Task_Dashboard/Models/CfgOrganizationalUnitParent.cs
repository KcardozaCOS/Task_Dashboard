using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgOrganizationalUnitParent
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public Guid ChildId { get; set; }

        public virtual OrganizationalUnit Child { get; set; }
        public virtual OrganizationalUnit Parent { get; set; }
    }
}
