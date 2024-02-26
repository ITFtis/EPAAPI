namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyOther")]
    public partial class ApplyOther
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiasterId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TownId { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime RequireDate { get; set; }

        public string EstimationMethodDescribe { get; set; }

        public string PhotoDescribe { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string ContactPerson { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        [StringLength(50)]
        public string ContactMobilePhone { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UpdateDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string UpdateUser { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        public int? EPBConfirmStatus { get; set; }

        public DateTime? EPBConfirmUpdateTime { get; set; }

        public int? EPAConfirmStatus { get; set; }

        public DateTime? EPAConfirmUpdateTime { get; set; }

        public int? PostStatus { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsToEpa { get; set; }

        [StringLength(500)]
        public string EPBConfirmDescribe { get; set; }

        [StringLength(500)]
        public string EPAConfirmDescribe { get; set; }
    }
}
