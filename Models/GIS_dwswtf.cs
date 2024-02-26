namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIS_dwswtf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pkey { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public double? longitude { get; set; }

        public double? latitude { get; set; }

        [StringLength(50)]
        public string county { get; set; }

        [StringLength(50)]
        public string town { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string other_A { get; set; }

        [StringLength(50)]
        public string other_B { get; set; }

        [StringLength(50)]
        public string other_C { get; set; }

        [StringLength(50)]
        public string other_D { get; set; }

        [StringLength(50)]
        public string other_E { get; set; }
    }
}
