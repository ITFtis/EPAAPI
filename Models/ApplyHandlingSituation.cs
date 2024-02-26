namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyHandlingSituation")]
    public partial class ApplyHandlingSituation
    {
        public int Id { get; set; }

        public int ApplyType { get; set; }

        public int ApplyId { get; set; }

        public int Type { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public decimal Subsidy { get; set; }
    }
}
