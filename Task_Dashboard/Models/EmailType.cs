using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class EmailType
    {
        public EmailType()
        {
            PersonEmails = new HashSet<PersonEmail>();
        }

        public Guid Id { get; set; }
        public string Type { get; set; }
        public int? Rank { get; set; }
        public bool System { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<PersonEmail> PersonEmails { get; set; }
    }
}
