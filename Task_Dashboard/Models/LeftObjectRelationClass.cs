using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LeftObjectRelationClass
    {
        public Guid Id { get; set; }
        public Guid RelationTypeId { get; set; }
        public Guid ClassId { get; set; }

        public virtual ObjectClass Class { get; set; }
        public virtual ObjectRelationType RelationType { get; set; }
    }
}
