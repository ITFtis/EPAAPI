namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUP_MONEY_LIST_ME
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public int? IDS { get; set; }

        [StringLength(50)]
        public string ITEM { get; set; }

        [StringLength(50)]
        public string QTY { get; set; }

        [StringLength(50)]
        public string MONEY { get; set; }

        public DateTime? N_DATE2 { get; set; }

        [StringLength(50)]
        public string SURE_QTY { get; set; }

        [StringLength(50)]
        public string SURE_MONEY { get; set; }

        public int? IDX { get; set; }
    }
}
