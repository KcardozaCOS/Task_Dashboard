using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class StockMovement
    {
        public Guid Id { get; set; }
        public Guid? SourceStockRoomId { get; set; }
        public string SourceStockRoomName { get; set; }
        public Guid? SourcePersonId { get; set; }
        public string SourcePersonOid { get; set; }
        public string SourcePersonName { get; set; }
        public Guid? SourceAssetId { get; set; }
        public string SourceAssetOid { get; set; }
        public string SourceAssetName { get; set; }
        public Guid? SourceConsumableId { get; set; }
        public Guid? TargetStockRoomId { get; set; }
        public string TargetStockRoomName { get; set; }
        public Guid? TargetPersonId { get; set; }
        public string TargetPersonOid { get; set; }
        public string TargetPersonName { get; set; }
        public Guid? TargetAssetId { get; set; }
        public string TargetAssetOid { get; set; }
        public string TargetAssetName { get; set; }
        public Guid? TargetConsumableId { get; set; }
        public string TargetConsumableOid { get; set; }
        public string TargetConsumableName { get; set; }
        public Guid? StockManagerId { get; set; }
        public string StockManagerOid { get; set; }
        public string StockManagerName { get; set; }
        public Guid? PoId { get; set; }
        public string PoOid { get; set; }
        public string PoName { get; set; }
        public DateTime? Date { get; set; }
        public int? Quantity { get; set; }
        public string Comment { get; set; }
        public int? SourceBalance { get; set; }
        public int? TargetBalance { get; set; }
        public Guid? ReasonId { get; set; }

        public virtual StockMovementReason Reason { get; set; }
        public virtual Consumable SourceConsumable { get; set; }
    }
}
