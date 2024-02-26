namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolymerDetail")]
    public partial class PolymerDetail
    {
        public int Id { get; set; }

        public int PolymerId { get; set; }

        public DateTime UseDate { get; set; }

        public decimal UseAmount { get; set; }

        public decimal WaterAmount { get; set; }

        public decimal DrugAmount { get; set; }

        public decimal Turbidity { get; set; }

        public decimal Inventory { get; set; }

        public decimal OriginalInventory { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateUser { get; set; }
    }
}
