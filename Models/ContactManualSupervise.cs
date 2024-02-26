namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactManualSupervise")]
    public partial class ContactManualSupervise
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        [Required]
        public string Describe { get; set; }

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
