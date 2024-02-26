namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplySubsidyDetail")]
    public partial class ApplySubsidyDetail
    {
        public int Id { get; set; }

        public int ApplySubsidyId { get; set; }

        public int ApplySubsidyTypeId { get; set; }

        public int ApplySubsidyTypeDetailId { get; set; }

        public int? Quantity { get; set; }

        public int? NeedDays { get; set; }

        public decimal? Price { get; set; }

        [StringLength(5)]
        public string Unit { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
