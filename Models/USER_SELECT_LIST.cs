namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_SELECT_LIST
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PART1 { get; set; }

        [StringLength(50)]
        public string PART1_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string PART2 { get; set; }

        [StringLength(50)]
        public string PART2_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LEV_Old { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool PART1_MAIN { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pkid { get; set; }
    }
}
