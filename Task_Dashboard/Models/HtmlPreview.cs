using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class HtmlPreview
    {
        public Guid Id { get; set; }
        public int ObjectClass { get; set; }
        public string Page { get; set; }
    }
}
