namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileUpload")]
    public partial class FileUpload
    {
        [StringLength(200)]
        public string FILENAME { get; set; }

        [StringLength(200)]
        public string FILETEXT { get; set; }

        [StringLength(10)]
        public string DOWNADMIN { get; set; }

        public int? USERLV { get; set; }

        [StringLength(50)]
        public string USERID { get; set; }

        public DateTime? UPTIME { get; set; }

        public int ID { get; set; }
    }
}
