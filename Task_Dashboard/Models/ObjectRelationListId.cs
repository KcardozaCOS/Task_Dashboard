using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectRelationListId
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public Guid LinkedObjectId { get; set; }
        public Guid RelationTypeId { get; set; }
        public string RelationshipType { get; set; }
    }
}
