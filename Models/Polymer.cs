namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Polymer")]
    public partial class Polymer
    {
        public int Id { get; set; }

        public int DiasterId { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string MainContacter { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string DrugName { get; set; }

        [StringLength(50)]
        public string ChemicalFormula { get; set; }

        [StringLength(50)]
        public string Vendor { get; set; }

        public DateTime BuyDate { get; set; }

        public decimal Amount { get; set; }

        public DateTime EffectiveDate { get; set; }

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
