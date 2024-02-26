namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIS_eetown
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(255)]
        public string TOWNNAME { get; set; }

        [StringLength(255)]
        public string CITYNAME { get; set; }

        [StringLength(255)]
        public string ZIP { get; set; }

        public double? LONGITUDE { get; set; }

        public double? LATITUDE { get; set; }
    }
}
