using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class HtmlStyle
    {
        public Guid Id { get; set; }
        public string HtmlStyle1 { get; set; }
        public string BodyTemplate { get; set; }
        public string CategoryTemplate { get; set; }
        public string AttachmentTemplate { get; set; }
    }
}
