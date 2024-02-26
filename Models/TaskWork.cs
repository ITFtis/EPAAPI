namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskWork")]
    public partial class TaskWork
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Executor { get; set; }

        [StringLength(500)]
        public string IssueDesc { get; set; }

        [StringLength(500)]
        public string ProgressDesc { get; set; }

        public int Status { get; set; }

        public int? TownId { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime PhoneTime { get; set; }

        public DateTime? CompleteTime { get; set; }
    }
}
