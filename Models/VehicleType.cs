namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleType")]
    public partial class VehicleType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Type { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
