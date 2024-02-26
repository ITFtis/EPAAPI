namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ddibak")]
    public partial class ddibak
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(30)]
        public string ContactUnit { get; set; }

        [StringLength(30)]
        public string DrugName { get; set; }

        [StringLength(5)]
        public string DrugType { get; set; }

        [StringLength(2)]
        public string DrugState { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal Amount { get; set; }

        [StringLength(6)]
        public string Density { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal Area { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime ServiceLife { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime UpdateTime { get; set; }

        public DateTime? ConfirmTime { get; set; }

        public int? UseType { get; set; }
    }
}
