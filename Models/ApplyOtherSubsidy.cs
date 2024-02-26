namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyOtherSubsidy")]
    public partial class ApplyOtherSubsidy
    {
        public int Id { get; set; }

        public int ApplyOtherId { get; set; }

        public int SubsidyType { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }
    }
}
