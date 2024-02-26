namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("District")]
    public partial class District
    {
        [StringLength(3)]
        public string Id { get; set; }

        [StringLength(20)]
        public string DistrictName { get; set; }

        [StringLength(10)]
        public string CoverArea { get; set; }

        [StringLength(30)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        public string Mail { get; set; }

        [StringLength(10)]
        public string Service { get; set; }

        [StringLength(10)]
        public string Human { get; set; }

        [StringLength(10)]
        public string OutHuman { get; set; }

        [StringLength(10)]
        public string ReadyHuman { get; set; }

        [StringLength(10)]
        public string CleanCapacity { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? ConfirmTime { get; set; }
    }
}
