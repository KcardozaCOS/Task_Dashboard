using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgLcemail
    {
        public CfgLcemail()
        {
            CfgLcemailParams = new HashSet<CfgLcemailParam>();
            CfgLcemailSections = new HashSet<CfgLcemailSection>();
            CfgLcoperations = new HashSet<CfgLcoperation>();
        }

        public Guid Id { get; set; }
        public Guid WfobjectId { get; set; }
        public string Name { get; set; }
        public int MessageId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int ContentType { get; set; }
        public Guid? TemplateId { get; set; }

        public virtual CfgLcemailTemplate Template { get; set; }
        public virtual ICollection<CfgLcemailParam> CfgLcemailParams { get; set; }
        public virtual ICollection<CfgLcemailSection> CfgLcemailSections { get; set; }
        public virtual ICollection<CfgLcoperation> CfgLcoperations { get; set; }
    }
}
