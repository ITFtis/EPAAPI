namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUPPORT_MAIN
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

        public int? NAME_ID { get; set; }

        [Column(TypeName = "ntext")]
        public string DESCRIPT { get; set; }

        public DateTime? ENTER_DATE { get; set; }
    }
}
