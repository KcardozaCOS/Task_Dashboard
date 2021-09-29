using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class StockRule
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? StockRoomId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public int? Threshold1 { get; set; }
        public Guid? ThresholdAction1Id { get; set; }
        public int? ReorderQuantity1 { get; set; }
        public int? Threshold2 { get; set; }
        public Guid? ThresholdAction2Id { get; set; }
        public int? ReorderQuantity2 { get; set; }
        public string Notes { get; set; }

        public virtual ObjectCategory Category { get; set; }
        public virtual Product Product { get; set; }
        public virtual Status Status { get; set; }
        public virtual StockRoom StockRoom { get; set; }
        public virtual ThresholdAction ThresholdAction1 { get; set; }
        public virtual ThresholdAction ThresholdAction2 { get; set; }
        public virtual ObjectType Type { get; set; }
    }
}
