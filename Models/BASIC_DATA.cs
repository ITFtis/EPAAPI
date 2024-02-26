namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BASIC_DATA
    {
        [Key]
        public int SN { get; set; }

        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(10)]
        public string COUNTY_ID { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        public decimal? AREA { get; set; }

        [StringLength(100)]
        public string ADDR { get; set; }

        [StringLength(50)]
        public string DEPARTMENT { get; set; }

        [StringLength(50)]
        public string TEL { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        public int? CLE_PEO { get; set; }

        public int? OUT_PEO { get; set; }

        public int? SUP_PEO { get; set; }

        public decimal? AVG_CLEAN { get; set; }

        public DateTime? VALID_DATE2 { get; set; }

        [StringLength(7)]
        public string VALID_DATE { get; set; }

        public double? xx { get; set; }

        public double? yy { get; set; }
    }
}
