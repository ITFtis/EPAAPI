namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfectiousDisease")]
    public partial class InfectiousDisease
    {
        public int Id { get; set; }

        public int? CityId { get; set; }

        public int? TownId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? HomeQuarantineCount { get; set; }

        public decimal? HomeQuarantineGarbageAmount { get; set; }

        public int? HomeInspectionCount { get; set; }

        public decimal? HomeInspectionGarbageAmount { get; set; }

        public int? InspectionHotelCount { get; set; }

        public decimal? InspectionHotelGarbageAmount { get; set; }

        public int? MaskCheckTimes { get; set; }

        public int? ReportTimes { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string UpdateUser { get; set; }
    }
}
