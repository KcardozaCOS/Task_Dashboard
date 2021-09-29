using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class HtmlImage
    {
        public Guid Id { get; set; }
        public Guid ObjectId { get; set; }
        public string ImageType { get; set; }
        public byte[] Image { get; set; }
    }
}
