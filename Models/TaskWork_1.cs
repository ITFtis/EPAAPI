namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TaskWork_1
    {
        [Key]
        public int SN { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PhoneTime { get; set; }

        [StringLength(50)]
        public string WhoCallin { get; set; }

        [StringLength(50)]
        public string WhoGet { get; set; }

        public string WhatHappen { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        [StringLength(50)]
        public string man1 { get; set; }

        public int? state1 { get; set; }

        public int? state2 { get; set; }

        public int? BadID { get; set; }

        public string WhatNow { get; set; }

        [StringLength(50)]
        public string CreatID { get; set; }

        [StringLength(50)]
        public string UpdateID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CompleteTime { get; set; }
    }
}
