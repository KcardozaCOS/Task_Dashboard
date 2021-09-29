using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectRelationType
    {
        public ObjectRelationType()
        {
            LeftObjectRelationClasses = new HashSet<LeftObjectRelationClass>();
            ObjectRelations = new HashSet<ObjectRelation>();
            RightObjectRelationClasses = new HashSet<RightObjectRelationClass>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string InverseName { get; set; }
        public bool System { get; set; }
        public int? Rank { get; set; }
        public bool FieldLink { get; set; }

        public virtual ICollection<LeftObjectRelationClass> LeftObjectRelationClasses { get; set; }
        public virtual ICollection<ObjectRelation> ObjectRelations { get; set; }
        public virtual ICollection<RightObjectRelationClass> RightObjectRelationClasses { get; set; }
    }
}
