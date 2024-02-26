namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        public int Id { get; set; }

        [Column("City")]
        [Required]
        [StringLength(20)]
        public string City1 { get; set; }

        public int AreaId { get; set; }

        public bool IsCounty { get; set; }

        public int WaterDivisionId { get; set; }

        public int Sort { get; set; }

        public int? type { get; set; }
    }
}
