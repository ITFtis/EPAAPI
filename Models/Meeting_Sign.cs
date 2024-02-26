namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Meeting_Sign
    {
        [Key]
        [Column(Order = 0)]
        public int Meeting_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Meeting_name { get; set; }

        [StringLength(300)]
        public string Meeting_Datetime { get; set; }

        [StringLength(300)]
        public string Meeting_Address { get; set; }

        [StringLength(2000)]
        public string Meeting_Issue { get; set; }

        [StringLength(2000)]
        public string Meeting_Memo { get; set; }

        public DateTime? Meeting_Sign_BeginTime { get; set; }

        public DateTime? Meeting_Sign_EndTime { get; set; }

        [StringLength(10)]
        public string Meeting_Food { get; set; }

        public DateTime? Meeting_Food_Begin { get; set; }

        public DateTime? Meeting_Food_End { get; set; }

        public int? Meeting_Traffic { get; set; }

        [StringLength(200)]
        public string Traffic_Go_1 { get; set; }

        [StringLength(200)]
        public string Traffic_Go_2 { get; set; }

        [StringLength(200)]
        public string Traffic_Go_3 { get; set; }

        [StringLength(200)]
        public string Traffic_Back_1 { get; set; }

        [StringLength(200)]
        public string Traffic_Back_2 { get; set; }

        [StringLength(200)]
        public string Traffic_Back_3 { get; set; }

        public int? Meeting_people_Sum { get; set; }

        public DateTime? Meeting_Keyin_date { get; set; }

        [StringLength(50)]
        public string Meeting_Keyin_name { get; set; }

        [StringLength(1)]
        public string del { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaximumAttendance { get; set; }
    }
}
