namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUP_MONEY_LIST_EPA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public int? IDS { get; set; }

        [StringLength(255)]
        public string NOTE { get; set; }

        [StringLength(50)]
        public string SURE_MONEY { get; set; }

        public int? EPApkid { get; set; }

        public int? IDX { get; set; }
    }
}
