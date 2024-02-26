namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Landfill")]
    public partial class Landfill
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [StringLength(300)]
        public string ContactUnit { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal Xpos { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal Ypos { get; set; }

        [StringLength(300)]
        public string City { get; set; }

        [StringLength(300)]
        public string Town { get; set; }

        [StringLength(10)]
        public string DesignCapacity { get; set; }

        [StringLength(10)]
        public string ResidualCapacity { get; set; }

        [StringLength(100)]
        public string ContactPerson { get; set; }

        [StringLength(100)]
        public string ContactPersonTitle { get; set; }

        [StringLength(100)]
        public string ContactPhone { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(1)]
        public string IsDump { get; set; }

        public DateTime? ConfirmTime { get; set; }
    }
}
