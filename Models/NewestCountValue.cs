namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewestCountValue")]
    public partial class NewestCountValue
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
        public string SolidDisinfectant { get; set; }

        [StringLength(20)]
        public string LiquidDisinfectant { get; set; }

        [StringLength(20)]
        public string Dump { get; set; }

        [StringLength(20)]
        public string Toilet { get; set; }

        [StringLength(20)]
        public string Users { get; set; }

        [StringLength(20)]
        public string Pest { get; set; }

        [StringLength(20)]
        public string Vehicle { get; set; }

        [StringLength(20)]
        public string Volunteer { get; set; }

        [StringLength(20)]
        public string Reporter { get; set; }

        [StringLength(20)]
        public string ReportPhone { get; set; }

        [StringLength(20)]
        public string UpdateTIme { get; set; }

        [StringLength(20)]
        public string ConfirmTIme { get; set; }
    }
}
