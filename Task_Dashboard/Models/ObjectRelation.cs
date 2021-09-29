using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectRelation
    {
        public Guid Id { get; set; }
        public Guid LeftObjectId { get; set; }
        public Guid RightObjectId { get; set; }
        public Guid TypeId { get; set; }

        public virtual ObjectIndex LeftObject { get; set; }
        public virtual ObjectIndex RightObject { get; set; }
        public virtual ObjectRelationType Type { get; set; }
    }
}
