namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diaster")]
    public partial class Diaster
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string DiasterName { get; set; }

        [StringLength(30)]
        public string DiasterType { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string Comment { get; set; }

        [StringLength(30)]
        public string DiasterState { get; set; }

        [StringLength(23)]
        public string CoverCity { get; set; }

        public int? Status { get; set; }
    }
}
