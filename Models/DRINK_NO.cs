namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DRINK_NO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DN_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FIRST_NO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ADMIT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string COUNTY_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime CH_DATE2 { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smalldatetime")]
        public DateTime ENTER_DATE2 { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string ENTER_USER { get; set; }

        [StringLength(100)]
        public string EXP { get; set; }
    }
}
