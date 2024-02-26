namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mail")]
    public partial class Mail
    {
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(20)]
        public string Topic { get; set; }

        public string MailAddress { get; set; }

        public string Content { get; set; }

        [StringLength(20)]
        public string SendTime { get; set; }

        [StringLength(20)]
        public string SendResult { get; set; }
    }
}
