namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SendTextLog")]
    public partial class SendTextLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Topic { get; set; }

        [Required]
        [StringLength(1000)]
        public string Message { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
    }
}
