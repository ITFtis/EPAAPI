namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string PlateNumber { get; set; }


      
        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        [NotMapped]
        public string _City
        {
            get
            {

                if (City == "台北市")
                {
                    return "臺北市";
                }
                if (City == "台南市")
                {
                    return "臺南市";
                }
                if (City == "台東市")
                {
                    return "臺東市";
                }
                if (City == "台東縣")
                {
                    return "臺東縣";
                }
                if (City == "台中市")
                {
                    return "臺中市";
                }
                if (City == "")
                {
                    return "error";
                }



                return City;
            }
            set
            {
            }
        }





        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(50)]
        public string ContactUnit { get; set; }

        [StringLength(50)]
        public string VehicleName { get; set; }

        [StringLength(20)]
        public string VehicleState { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdateTime { get; set; }

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

        [StringLength(150)]
        public string RptKind { get; set; }

        [StringLength(10)]
        public string VhlRecDiscard { get; set; }
    }
}
