namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Toilet")]
    public partial class Toilet
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal Amount { get; set; }

        [StringLength(5)]
        public string SlotNumber { get; set; }

        [StringLength(3)]
        public string ToiletType { get; set; }

        [StringLength(3)]
        public string ROCyear { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(100)]
        public string ContactUnit { get; set; }

        public DateTime? ConfirmTime { get; set; }
    }
}
