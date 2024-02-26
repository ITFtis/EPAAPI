namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactManualDepartment")]
    public partial class ContactManualDepartment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Type { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(30)]
        public string CreateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(30)]
        public string UpdateUser { get; set; }

        public int? Sort { get; set; }
    }
}
