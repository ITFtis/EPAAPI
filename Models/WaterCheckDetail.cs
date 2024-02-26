namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WaterCheckDetail")]
    public partial class WaterCheckDetail
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WaterCheckId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CityName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TownId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string TownName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CheckTime { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string UpdateUser { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal O_Turbidity { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal Chlorine { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChlorineStand { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChlorineWay { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal EColi { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EColiType { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EColiStand { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EColiWay { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal Hydrogen { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HydrogenStand { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HydrogenWay { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal Turbidity { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TurbidityStand { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TurbidityWay { get; set; }

        [StringLength(50)]
        public string OtherName { get; set; }

        public decimal? OtherValue { get; set; }

        [StringLength(200)]
        public string OtherWay { get; set; }

        [StringLength(50)]
        public string Other2Name { get; set; }

        public decimal? Other2Value { get; set; }

        [StringLength(200)]
        public string Other2Way { get; set; }

        [StringLength(50)]
        public string Other3Name { get; set; }

        public decimal? Other3Value { get; set; }

        [StringLength(200)]
        public string Other3Way { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal GpsX { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal GpsY { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Recheck { get; set; }
    }
}
