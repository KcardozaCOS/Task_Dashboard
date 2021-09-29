using System;
using System.Collections.Generic;

#nullable disable

namespace Task_Dashboard.Models
{
    public partial class SecComputer
    {
        public Guid Id { get; set; }
        public string Oid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? LocationId { get; set; }
        public string SerialNum { get; set; }
        public string Notes { get; set; }
        public DateTime? AuditDate { get; set; }
        public string AuditId { get; set; }
        public string ComputerName { get; set; }
        public string Cpu { get; set; }
        public int? CpuCount { get; set; }
        public double? CpuSpeed { get; set; }
        public string DisplayAdapter { get; set; }
        public string Domain { get; set; }
        public double? Hdd { get; set; }
        public double? HddFree { get; set; }
        public DateTime? InstallDate { get; set; }
        public string LanCard { get; set; }
        public string Mac { get; set; }
        public Guid? ManufacturerId { get; set; }
        public string Model { get; set; }
        public string OsName { get; set; }
        public string OsServicePack { get; set; }
        public string OsVersion { get; set; }
        public string Product { get; set; }
        public int? Ram { get; set; }
        public string Workgroup { get; set; }
        public Guid? NetworkId { get; set; }
        public string Monitor { get; set; }
        public string Udf0007 { get; set; }
        public string Udf0001 { get; set; }
        public Guid? ImportId { get; set; }
        public DateTime? UdfLegacyWarrantyExp { get; set; }
        public string PrimaryIpAddress { get; set; }
    }
}
