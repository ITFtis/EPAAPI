namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUPPORT_CASH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        public int? NAME_ID { get; set; }

        public int? PAY_AMOUNT { get; set; }

        public DateTime? UP_DATE2 { get; set; }

        [StringLength(7)]
        public string UP_DATE { get; set; }
    }
}
