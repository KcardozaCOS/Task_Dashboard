using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LibraryHistory
    {
        public Guid Id { get; set; }
        public DateTime? DueDate { get; set; }
        public Guid LibraryItemId { get; set; }
        public DateTime? OutDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Guid? UserId { get; set; }

        public virtual Library LibraryItem { get; set; }
        public virtual Person User { get; set; }
    }
}
