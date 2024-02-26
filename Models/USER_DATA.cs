namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_DATA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUM { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(50)]
        public string PWD { get; set; }

        [StringLength(50)]
        public string PART1 { get; set; }

        [StringLength(50)]
        public string PART2 { get; set; }

        public int? LEV { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string TEL2 { get; set; }

        [StringLength(50)]
        public string TEL3 { get; set; }

        [StringLength(50)]
        public string TEL { get; set; }

        [StringLength(1)]
        public string IS_Manage { get; set; }

        [StringLength(6)]
        public string CTI_PWD { get; set; }

        public int? LEV_ID { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        [StringLength(50)]
        public string DEPARTMENT { get; set; }

        [StringLength(50)]
        public string P_JOB { get; set; }

        [StringLength(50)]
        public string P_TYPE { get; set; }

        public int? P_ORDER { get; set; }

        public int? P_MAIN { get; set; }

        [StringLength(50)]
        public string FAX2 { get; set; }

        [StringLength(50)]
        public string FAX3 { get; set; }

        [StringLength(50)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string H_TEL3 { get; set; }

        [StringLength(50)]
        public string H_TEL2 { get; set; }

        [StringLength(50)]
        public string H_TEL { get; set; }

        [StringLength(50)]
        public string M_TEL2 { get; set; }

        [StringLength(50)]
        public string M_TEL3 { get; set; }

        [StringLength(50)]
        public string M_TEL { get; set; }

        [StringLength(100)]
        public string EMAIL2 { get; set; }

        [StringLength(100)]
        public string EMAIL3 { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(255)]
        public string NOTE1 { get; set; }

        [StringLength(50)]
        public string Hold_Disaster_Item { get; set; }

        public DateTime? VALID_DATE2 { get; set; }

        public DateTime? VALID_DATE { get; set; }

        [StringLength(50)]
        public string U_USERNAME { get; set; }

        [StringLength(2)]
        public string ReadOnly { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Delete_YN { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool NotSchedule { get; set; }

        [StringLength(50)]
        public string PWDMD5 { get; set; }
    }
}
