namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenContractDetail")]
    public partial class OpenContractDetail
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OpenContractId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Items { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Count { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Price { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal Budge { get; set; }

        public int? ItemCategoryId { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string UpdateUser { get; set; }

        public int? Status { get; set; }
    }
}
