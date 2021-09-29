using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class LibraryHistoryList
    {
        public Guid Id { get; set; }
        public Guid LibraryItemId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? OutDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string User { get; set; }
    }
}
