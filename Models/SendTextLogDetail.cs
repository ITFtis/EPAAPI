namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SendTextLogDetail")]
    public partial class SendTextLogDetail
    {
        public int Id { get; set; }

        public int SendTextLogId { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SendTime { get; set; }

        public bool IsSuccess { get; set; }

        [StringLength(1000)]
        public string ResultMessage { get; set; }

        [StringLength(100)]
        public string BatchId { get; set; }

        [StringLength(100)]
        public string Status { get; set; }
    }
}
