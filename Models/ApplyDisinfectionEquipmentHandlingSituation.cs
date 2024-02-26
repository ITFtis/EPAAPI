namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyDisinfectionEquipmentHandlingSituation")]
    public partial class ApplyDisinfectionEquipmentHandlingSituation
    {
        public int Id { get; set; }

        public int ApplyId { get; set; }

        public int Type { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int Day { get; set; }

        public decimal Subsidy { get; set; }
    }
}
