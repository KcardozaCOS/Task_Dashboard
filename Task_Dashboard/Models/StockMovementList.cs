using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class StockMovementList
    {
        public Guid Id { get; set; }
        public Guid? SourceStockRoomId { get; set; }
        public string SourceStockRoom { get; set; }
        public Guid? TargetStockRoomId { get; set; }
        public string TargetStockRoom { get; set; }
        public Guid? StockManagerId { get; set; }
        public string StockManager { get; set; }
        public Guid? SourcePersonId { get; set; }
        public string SourcePerson { get; set; }
        public string SourcePersonOid { get; set; }
        public Guid? TargetPersonId { get; set; }
        public string TargetPerson { get; set; }
        public string TargetPersonOid { get; set; }
        public Guid? SourceAssetId { get; set; }
        public string SourceAsset { get; set; }
        public string SourceAssetOid { get; set; }
        public Guid? TargetAssetId { get; set; }
        public string TargetAsset { get; set; }
        public string TargetAssetOid { get; set; }
        public Guid? SourceConsumableId { get; set; }
        public string SourceConsumable { get; set; }
        public string SourceConsumableOid { get; set; }
        public Guid? TargetConsumableId { get; set; }
        public string TargetConsumable { get; set; }
        public string TargetConsumableOid { get; set; }
        public Guid? PoId { get; set; }
        public string PurchaseOrder { get; set; }
        public string PurchaseOrderOid { get; set; }
        public string Direction { get; set; }
        public DateTime? Date { get; set; }
        public int? Quantity { get; set; }
        public string Comment { get; set; }
        public int? SourceBalance { get; set; }
        public int? TargetBalance { get; set; }
        public string Reason { get; set; }
    }
}
