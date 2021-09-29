using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgObjectsRelationshipList
    {
        public Guid? ObjectId { get; set; }
        public Guid? RelatedObjectId { get; set; }
    }
}
