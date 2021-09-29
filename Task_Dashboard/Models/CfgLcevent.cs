using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcevent
    {
        public CfgLcevent()
        {
            CfgAdjobOptionLocationConstructors = new HashSet<CfgAdjobOption>();
            CfgAdjobOptionOuConstructors = new HashSet<CfgAdjobOption>();
            CfgAdjobOptionPersonConstructors = new HashSet<CfgAdjobOption>();
            CfgAdjobOptionPersonTasks = new HashSet<CfgAdjobOption>();
            CfgDscjobOptionComputerConstructors = new HashSet<CfgDscjobOption>();
            CfgDscjobOptionComputerTasks = new HashSet<CfgDscjobOption>();
            CfgDscjobOptionHardwareConstructors = new HashSet<CfgDscjobOption>();
            CfgDscjobOptionHardwareTasks = new HashSet<CfgDscjobOption>();
            CfgDscjobOptionLocationConstructors = new HashSet<CfgDscjobOption>();
            CfgDscjobOptionOuConstructors = new HashSet<CfgDscjobOption>();
            CfgDscjobOptionPersonConstructors = new HashSet<CfgDscjobOption>();
            CfgLceventRoles = new HashSet<CfgLceventRole>();
            CfgLcobjectHistories = new HashSet<CfgLcobjectHistory>();
            CfgLcprocessItems = new HashSet<CfgLcprocessItem>();
            CfgLcrecurrentObjects = new HashSet<CfgLcrecurrentObject>();
            CfgLcserviceFieldMappings = new HashSet<CfgLcserviceFieldMapping>();
            CfgLctoolbarActions = new HashSet<CfgLctoolbarAction>();
            CfgMcjobOptions = new HashSet<CfgMcjobOption>();
            CfgServiceOperations = new HashSet<CfgServiceOperation>();
            CfgWflogs = new HashSet<CfgWflog>();
        }

        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public int EventKind { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public string Hint { get; set; }
        public int Rank { get; set; }
        public string Types { get; set; }
        public string Statuses { get; set; }
        public string Condition { get; set; }
        public int? Interval { get; set; }
        public Guid? TemplateId { get; set; }
        public Guid? FormId { get; set; }
        public Guid? FunctionId { get; set; }
        public string Message { get; set; }
        public bool System { get; set; }
        public bool Enabled { get; set; }
        public string Params { get; set; }
        public string GroupName { get; set; }
        public bool AnyRole { get; set; }
        public bool Reopen { get; set; }
        public Guid? ImageId { get; set; }
        public bool Embedded { get; set; }

        public virtual CfgLcform Form { get; set; }
        public virtual CfgLcfunction Function { get; set; }
        public virtual CfgLcimage Image { get; set; }
        public virtual CfgLctemplate Template { get; set; }
        public virtual CfgWfobject Wfobject { get; set; }
        public virtual ICollection<CfgAdjobOption> CfgAdjobOptionLocationConstructors { get; set; }
        public virtual ICollection<CfgAdjobOption> CfgAdjobOptionOuConstructors { get; set; }
        public virtual ICollection<CfgAdjobOption> CfgAdjobOptionPersonConstructors { get; set; }
        public virtual ICollection<CfgAdjobOption> CfgAdjobOptionPersonTasks { get; set; }
        public virtual ICollection<CfgDscjobOption> CfgDscjobOptionComputerConstructors { get; set; }
        public virtual ICollection<CfgDscjobOption> CfgDscjobOptionComputerTasks { get; set; }
        public virtual ICollection<CfgDscjobOption> CfgDscjobOptionHardwareConstructors { get; set; }
        public virtual ICollection<CfgDscjobOption> CfgDscjobOptionHardwareTasks { get; set; }
        public virtual ICollection<CfgDscjobOption> CfgDscjobOptionLocationConstructors { get; set; }
        public virtual ICollection<CfgDscjobOption> CfgDscjobOptionOuConstructors { get; set; }
        public virtual ICollection<CfgDscjobOption> CfgDscjobOptionPersonConstructors { get; set; }
        public virtual ICollection<CfgLceventRole> CfgLceventRoles { get; set; }
        public virtual ICollection<CfgLcobjectHistory> CfgLcobjectHistories { get; set; }
        public virtual ICollection<CfgLcprocessItem> CfgLcprocessItems { get; set; }
        public virtual ICollection<CfgLcrecurrentObject> CfgLcrecurrentObjects { get; set; }
        public virtual ICollection<CfgLcserviceFieldMapping> CfgLcserviceFieldMappings { get; set; }
        public virtual ICollection<CfgLctoolbarAction> CfgLctoolbarActions { get; set; }
        public virtual ICollection<CfgMcjobOption> CfgMcjobOptions { get; set; }
        public virtual ICollection<CfgServiceOperation> CfgServiceOperations { get; set; }
        public virtual ICollection<CfgWflog> CfgWflogs { get; set; }
    }
}
