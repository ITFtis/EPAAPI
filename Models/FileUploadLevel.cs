namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileUploadLevel")]
    public partial class FileUploadLevel
    {
        public int ID { get; set; }

        public int USER_LEV { get; set; }

        public int FILE_LEV { get; set; }
    }
}
