namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle_0822
    {
        public int Id { get; set; }

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

        [StringLength(20)]
        public string Load { get; set; }

        [StringLength(20)]
        public string EnginePower { get; set; }

        [StringLength(30)]
        public string ROCyear { get; set; }

        [StringLength(10)]
        public string EPAsubsidy { get; set; }

        [StringLength(10)]
        public string CrossCityUse { get; set; }

        [StringLength(10)]
        public string CrossTownUse { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public decimal? Xpos { get; set; }

        public decimal? Ypos { get; set; }

        [StringLength(100)]
        public string VehicleType { get; set; }

        [StringLength(200)]
        public string Purpose { get; set; }

        public DateTime? ConfirmTime { get; set; }
    }
}
