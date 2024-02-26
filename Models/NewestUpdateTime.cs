namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewestUpdateTime")]
    public partial class NewestUpdateTime
    {
        [StringLength(3)]
        public string Id { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Disinfector { get; set; }

        [StringLength(20)]
        public string Disinfectant { get; set; }

        [StringLength(20)]
        public string Dump { get; set; }

        [StringLength(20)]
        public string Toilet { get; set; }

        [StringLength(20)]
        public string Users { get; set; }

        [StringLength(20)]
        public string Landfill { get; set; }

        [StringLength(20)]
        public string Incinerator { get; set; }

        [StringLength(20)]
        public string District { get; set; }

        [StringLength(20)]
        public string Volunteer { get; set; }
    }
}
