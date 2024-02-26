namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyMedicineHandlingSituation")]
    public partial class ApplyMedicineHandlingSituation
    {
        public int Id { get; set; }

        public int ApplyId { get; set; }

        public int Type { get; set; }

        public int MedicineType { get; set; }

        public int Quantity { get; set; }

        public decimal Subsidy { get; set; }
    }
}
