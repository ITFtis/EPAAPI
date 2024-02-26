namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MutualSupport")]
    public partial class MutualSupport
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResourceTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string AcceptSection { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string Section { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupportType { get; set; }

        [StringLength(1000)]
        public string SupportContent { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime UpdateDate { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string UpdateUser { get; set; }
    }
}
