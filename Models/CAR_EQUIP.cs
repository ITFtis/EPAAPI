namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAR_EQUIP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(10)]
        public string COUNTY_ID { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        [StringLength(50)]
        public string DEPARTMENT { get; set; }

        [StringLength(50)]
        public string C_NAME { get; set; }

        [StringLength(30)]
        public string C_NUM { get; set; }

        public decimal? WEIGHT { get; set; }

        [StringLength(50)]
        public string EXPLAIN { get; set; }

        [StringLength(30)]
        public string BUY_DATE { get; set; }

        [StringLength(255)]
        public string NOTE1 { get; set; }

        public DateTime? VALID_DATE2 { get; set; }

        public DateTime? VALID_DATE { get; set; }

        public short? STATUS { get; set; }

        public double? XX { get; set; }

        public double? YY { get; set; }

        public string type { get; set; }

        public string CAR_TYPE { get; set; }

        [StringLength(50)]
        public string Horse_Power { get; set; }

        public int? CrossArea { get; set; }

        public int? purchase { get; set; }

        public int? CG_Support { get; set; }

        public int? EPA_Support { get; set; }

        [StringLength(100)]
        public string VhlKindName { get; set; }

        [StringLength(100)]
        public string UseMemo { get; set; }

        [StringLength(1)]
        public string CarNow { get; set; }
    }
}
