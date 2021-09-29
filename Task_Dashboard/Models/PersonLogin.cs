using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class PersonLogin
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public string Domain { get; set; }
        public string Login { get; set; }
        public bool Primary { get; set; }

        public virtual Person Person { get; set; }
    }
}
