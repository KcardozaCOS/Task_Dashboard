using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class CfgDisabledView
    {
        public Guid Id { get; set; }
        public Guid ViewId { get; set; }
        public Guid PersonId { get; set; }

        public virtual Person Person { get; set; }
        public virtual CfgView View { get; set; }
    }
}
