namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUP_Check_List
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public int? IDS { get; set; }

        [StringLength(10)]
        public string Category { get; set; }

        [StringLength(10)]
        public string TYPE { get; set; }

        [StringLength(50)]
        public string ITEM { get; set; }

        public int? QTY { get; set; }

        public int? DAY { get; set; }

        [StringLength(10)]
        public string UNIT { get; set; }

        public int? IDX { get; set; }

        public int? SUP_Status { get; set; }
    }
}
