namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DRINK_DETAIL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SNO { get; set; }

        public long? FIRST_NO { get; set; }

        [StringLength(50)]
        public string PRE_INDEX { get; set; }

        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(10)]
        public string COUNTY_ID { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        [StringLength(10)]
        public string CITY_ID { get; set; }

        [StringLength(150)]
        public string CH_PLACE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CH_DATE2 { get; set; }

        [StringLength(7)]
        public string CH_DATE { get; set; }

        [StringLength(50)]
        public string O_WATER { get; set; }

        public int? typ { get; set; }

        [StringLength(50)]
        public string dir_1 { get; set; }

        [StringLength(50)]
        public string dir_2 { get; set; }

        [StringLength(50)]
        public string dir_3 { get; set; }

        [StringLength(50)]
        public string dir_4 { get; set; }

        [StringLength(50)]
        public string dir_extra1 { get; set; }

        [StringLength(50)]
        public string dir_extra2 { get; set; }

        [StringLength(50)]
        public string dir_extra3 { get; set; }

        [StringLength(50)]
        public string dir_a { get; set; }

        [StringLength(50)]
        public string dir_b { get; set; }

        [StringLength(50)]
        public string dir_c { get; set; }

        [StringLength(50)]
        public string stand_2 { get; set; }

        [StringLength(50)]
        public string way_2 { get; set; }

        public short? makebetter { get; set; }

        public short? recheck { get; set; }

        public short? chk_condition { get; set; }

        public double? XX { get; set; }

        public double? YY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ENTER_DATE2 { get; set; }

        [StringLength(7)]
        public string ENTER_DATE { get; set; }

        [StringLength(50)]
        public string ENTER_USER { get; set; }

        [StringLength(50)]
        public string dir_stand_a { get; set; }

        [StringLength(50)]
        public string dir_stand_b { get; set; }

        [StringLength(50)]
        public string dir_stand_c { get; set; }

        [StringLength(50)]
        public string dir_way_a { get; set; }

        [StringLength(50)]
        public string dir_way_b { get; set; }

        [StringLength(50)]
        public string dir_way_c { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Check_DATE { get; set; }

        [StringLength(10)]
        public string COUNTY2_ID { get; set; }
    }
}
