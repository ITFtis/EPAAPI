namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Defend")]
    public partial class Defend
    {
        public int Id { get; set; }

        public int? DutyId { get; set; }

        public int DiasterId { get; set; }

        public int? CityId { get; set; }

        public int? TownId { get; set; }

        public int? Status { get; set; }

        [StringLength(200)]
        public string UpdateReason { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string Updator { get; set; }

        public DateTime? ConfirmTime { get; set; }

        [StringLength(50)]
        public string Confirmor { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        [StringLength(50)]
        public string SURE_OK { get; set; }
    }
}
