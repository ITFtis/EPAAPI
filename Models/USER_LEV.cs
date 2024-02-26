namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_LEV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LEV { get; set; }

        public int? LEV_PAR { get; set; }

        [StringLength(50)]
        public string LEV_NAME { get; set; }

        public bool? ABLE_PAR { get; set; }

        public bool? ADD_USER { get; set; }

        [StringLength(50)]
        public string PART1 { get; set; }

        [StringLength(50)]
        public string PART2 { get; set; }

        public int? LEV_Old { get; set; }
    }
}
