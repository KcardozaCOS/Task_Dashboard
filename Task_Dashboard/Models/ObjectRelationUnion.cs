using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectRelationUnion
    {
        public Guid? Id { get; set; }
        public Guid? ObjectId { get; set; }
        public Guid? LinkedObjectId { get; set; }
        public Guid RelationTypeId { get; set; }
        public string RelationshipType { get; set; }
        public string Class { get; set; }
        public int ClassIndex { get; set; }
        public string Oid { get; set; }
        public string ObjectName { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? TypeId { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Object { get; set; }
    }
}
