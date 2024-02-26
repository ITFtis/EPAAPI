namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASH_BURY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        [StringLength(255)]
        public string ADMIT { get; set; }

        [StringLength(10)]
        public string COUNTY_ID { get; set; }

        [StringLength(255)]
        public string COUNTY_NAME { get; set; }

        [StringLength(255)]
        public string Manager { get; set; }

        [StringLength(255)]
        public string Telephone { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public double? Capacity { get; set; }

        public DateTime? Close_date2 { get; set; }

        [StringLength(255)]
        public string Close_date { get; set; }

        public double? Tm2x { get; set; }

        public double? Tm2y { get; set; }

        public double? lon { get; set; }

        public double? lat { get; set; }

        [StringLength(255)]
        public string noname { get; set; }

        public DateTime? VALID_DATE2 { get; set; }

        [StringLength(50)]
        public string job { get; set; }

        public int? Gtype { get; set; }

        public double? Dcmd { get; set; }

        public double? Rcmd { get; set; }

        public int? Wtype { get; set; }

        public double? area { get; set; }

        public int? WastePile { get; set; }

        public double? total_capacity { get; set; }

        public int? Restoration { get; set; }

        [StringLength(200)]
        public string unitname { get; set; }
    }
}
