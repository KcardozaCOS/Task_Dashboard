using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLctemplateDefinition
    {
        public Guid Id { get; set; }
        public Guid TemplateId { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public bool Calculated { get; set; }

        public virtual CfgLctemplate Template { get; set; }
    }
}
