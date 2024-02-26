namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneWork")]
    public partial class PhoneWork
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiasterId { get; set; }

        [StringLength(50)]
        public string Speaker { get; set; }

        [StringLength(50)]
        public string Recorder { get; set; }

        [StringLength(50)]
        public string Executor { get; set; }

        public string IssueDesc { get; set; }

        public string ProgressDesc { get; set; }

        public int? Status { get; set; }

        public int? TownId { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? PhoneTime { get; set; }
    }
}
