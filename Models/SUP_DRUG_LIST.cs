namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUP_DRUG_LIST
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public int? IDS { get; set; }

        [StringLength(2)]
        public string type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C_NUM { get; set; }

        [StringLength(50)]
        public string SURE_NUM { get; set; }

        public int? IDX { get; set; }
    }
}
