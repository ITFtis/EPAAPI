namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplySubsidy")]
    public partial class ApplySubsidy
    {
        public int Id { get; set; }

        public int DiasterId { get; set; }

        public int CityId { get; set; }

        public int TownId { get; set; }

        [Column(TypeName = "date")]
        public DateTime RequireDate { get; set; }

        public string EstimationMethodDescribe { get; set; }

        public string PhotoDescribe { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactPerson { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        [StringLength(50)]
        public string ContactMobilePhone { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateUser { get; set; }

        public int Status { get; set; }

        public int? EPBConfirmStatus { get; set; }

        public DateTime? EPBConfirmUpdateTime { get; set; }

        public int? EPAConfirmStatus { get; set; }

        public DateTime? EPAConfirmUpdateTime { get; set; }

        public int? PostStatus { get; set; }

        public bool IsToEpa { get; set; }

        [StringLength(500)]
        public string EPBConfirmDescribe { get; set; }

        [StringLength(500)]
        public string EPAConfirmDescribe { get; set; }
    }
}
