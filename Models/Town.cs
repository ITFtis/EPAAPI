namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Town")]
    public partial class Town
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsTown { get; set; }
    }
}
