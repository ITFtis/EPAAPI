namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyPeople")]
    public partial class ApplyPeople
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiasterId { get; set; }

        public int? CityId { get; set; }

        public int? TownId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RequireDate { get; set; }

        public int? CleaningMemberQuantity { get; set; }

        public int? CleaningMemberDays { get; set; }

        public int? NationalArmyQuantity { get; set; }

        public int? NationalArmyDays { get; set; }

        public string EstimationMethodDescribe { get; set; }

        public string PhotoDescribe { get; set; }

        [StringLength(50)]
        public string ContactPerson { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        [StringLength(50)]
        public string ContactMobilePhone { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string UpdateUser { get; set; }

        public int? Status { get; set; }

        public int? EPBConfirmStatus { get; set; }

        public DateTime? EPBConfirmUpdateTime { get; set; }

        public int? EPAConfirmStatus { get; set; }

        public DateTime? EPAConfirmUpdateTime { get; set; }

        public int? PostStatus { get; set; }

        public bool? IsToEpa { get; set; }

        [StringLength(500)]
        public string EPBConfirmDescribe { get; set; }

        [StringLength(500)]
        public string EPAConfirmDescribe { get; set; }
    }
}
