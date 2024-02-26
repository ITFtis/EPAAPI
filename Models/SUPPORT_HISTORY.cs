namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUPPORT_HISTORY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public int? IDS { get; set; }

        [StringLength(10)]
        public string TYPE { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public DateTime? SaveTime { get; set; }

        public int? Status { get; set; }
    }
}
