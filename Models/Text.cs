namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Text")]
    public partial class Text
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Topic { get; set; }

        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Content { get; set; }

        public DateTime SendTime { get; set; }

        [StringLength(20)]
        public string SendResult { get; set; }
    }
}
