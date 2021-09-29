using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class ObjectClass
    {
        public ObjectClass()
        {
            CfgCalendarObjects = new HashSet<CfgCalendarObject>();
            CfgViewSettings = new HashSet<CfgViewSetting>();
            CfgWfobjects = new HashSet<CfgWfobject>();
            LeftObjectRelationClasses = new HashSet<LeftObjectRelationClass>();
            ObjectCategoryClasses = new HashSet<ObjectCategory>();
            ObjectCategorySubClasses = new HashSet<ObjectCategory>();
            ObjectIndices = new HashSet<ObjectIndex>();
            ObjectTypes = new HashSet<ObjectType>();
            PoItems = new HashSet<PoItem>();
            Products = new HashSet<Product>();
            RightObjectRelationClasses = new HashSet<RightObjectRelationClass>();
            Services = new HashSet<Service>();
            Statuses = new HashSet<Status>();
            TicketClosureCodes = new HashSet<TicketClosureCode>();
            TicketImpacts = new HashSet<TicketImpact>();
            TicketPriorities = new HashSet<TicketPriority>();
            TicketUrgencies = new HashSet<TicketUrgency>();
        }

        public Guid Id { get; set; }
        public bool Ci { get; set; }
        public bool Organization { get; set; }
        public string Description { get; set; }
        public string TableName { get; set; }
        public int ClassIndex { get; set; }
        public string Class { get; set; }

        public virtual ICollection<CfgCalendarObject> CfgCalendarObjects { get; set; }
        public virtual ICollection<CfgViewSetting> CfgViewSettings { get; set; }
        public virtual ICollection<CfgWfobject> CfgWfobjects { get; set; }
        public virtual ICollection<LeftObjectRelationClass> LeftObjectRelationClasses { get; set; }
        public virtual ICollection<ObjectCategory> ObjectCategoryClasses { get; set; }
        public virtual ICollection<ObjectCategory> ObjectCategorySubClasses { get; set; }
        public virtual ICollection<ObjectIndex> ObjectIndices { get; set; }
        public virtual ICollection<ObjectType> ObjectTypes { get; set; }
        public virtual ICollection<PoItem> PoItems { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RightObjectRelationClass> RightObjectRelationClasses { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }
        public virtual ICollection<TicketClosureCode> TicketClosureCodes { get; set; }
        public virtual ICollection<TicketImpact> TicketImpacts { get; set; }
        public virtual ICollection<TicketPriority> TicketPriorities { get; set; }
        public virtual ICollection<TicketUrgency> TicketUrgencies { get; set; }
    }
}
