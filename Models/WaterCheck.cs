namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WaterCheck")]
    public partial class WaterCheck
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiasterId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CityName { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TownId { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string TownName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "date")]
        public DateTime CheckDate { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(200)]
        public string UpdateUser { get; set; }
    }
}
