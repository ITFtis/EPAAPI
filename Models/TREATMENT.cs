namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TREATMENT")]
    public partial class TREATMENT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(10)]
        public string COUNTY_ID { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        [StringLength(50)]
        public string Tre_no { get; set; }

        [StringLength(50)]
        public string Tre_name { get; set; }

        [StringLength(50)]
        public string Tre_addr { get; set; }

        [StringLength(100)]
        public string addr_note { get; set; }

        [StringLength(50)]
        public string Tre_tel { get; set; }

        [StringLength(50)]
        public string Trec_boss { get; set; }

        [StringLength(50)]
        public string Per_no { get; set; }

        [StringLength(50)]
        public string Trade_item { get; set; }

        [StringLength(50)]
        public string Tre_class { get; set; }

        [StringLength(50)]
        public string Tre_grade { get; set; }

        [StringLength(50)]
        public string Con_tel { get; set; }

        [StringLength(50)]
        public string Notes { get; set; }

        [StringLength(50)]
        public string Ctrl_Pmtclass { get; set; }

        public double? Xcoord { get; set; }

        public double? ycoord { get; set; }
    }
}
