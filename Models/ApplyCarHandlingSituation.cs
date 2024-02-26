namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyCarHandlingSituation")]
    public partial class ApplyCarHandlingSituation
    {
        public int Id { get; set; }

        public int ApplyId { get; set; }

        public int Type { get; set; }

        public int CarType { get; set; }

        public int Quantity { get; set; }

        public int Day { get; set; }

        public decimal Subsidy { get; set; }
    }
}
