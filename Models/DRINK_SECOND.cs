namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DRINK_SECOND
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int num { get; set; }

        [StringLength(50)]
        public string sn { get; set; }

        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(10)]
        public string COUNTY_ID { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        public int? chk_num { get; set; }

        public int? chk_ok { get; set; }

        public int? chk_not_ok { get; set; }

        public int? chk_in { get; set; }

        [StringLength(250)]
        public string exp { get; set; }

        [StringLength(250)]
        public string EXP2 { get; set; }
    }
}
