namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUP_CAR_LIST
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public int? IDS { get; set; }

        [StringLength(50)]
        public string C_NAME { get; set; }

        [StringLength(5)]
        public string C_NUM { get; set; }

        [StringLength(50)]
        public string SURE_NUM { get; set; }

        [StringLength(1)]
        public string Da_no { get; set; }

        public int? IDX { get; set; }
    }
}
