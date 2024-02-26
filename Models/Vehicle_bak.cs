namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle_bak
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string PlateNumber { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(50)]
        public string ContactUnit { get; set; }

        [StringLength(50)]
        public string VehicleName { get; set; }

        [StringLength(20)]
        public string VehicleState { get; set; }

        [StringLength(20)]
        public string UpdateTime { get; set; }

        public decimal? Load { get; set; }

        public decimal? EnginePower { get; set; }

        [StringLength(30)]
        public string ROCyear { get; set; }

        [StringLength(10)]
        public string EPAsubsidy { get; set; }

        [StringLength(10)]
        public string CrossCityUse { get; set; }

        [StringLength(10)]
        public string CrossTownUse { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public decimal? Xpos { get; set; }

        public decimal? Ypos { get; set; }

        public int? VehicleType { get; set; }

        [StringLength(200)]
        public string Purpose { get; set; }

        public DateTime? ConfirmTime { get; set; }
    }
}
