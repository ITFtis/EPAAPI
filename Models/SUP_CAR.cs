namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUP_CAR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public int? IDX { get; set; }

        [StringLength(50)]
        public string C_NAME { get; set; }

        public int? C_NUM { get; set; }

        [StringLength(1200)]
        public string PREDICT_WAY { get; set; }

        public DateTime? N_DATE2 { get; set; }

        [StringLength(7)]
        public string N_DATE { get; set; }

        [StringLength(1200)]
        public string COND1 { get; set; }

        public int? TO_EPA { get; set; }

        [StringLength(1200)]
        public string COND2 { get; set; }

        public DateTime? ENTER_DATE2 { get; set; }

        [StringLength(20)]
        public string ENTER_DATE { get; set; }

        [StringLength(50)]
        public string ENTER_USER { get; set; }

        [StringLength(5)]
        public string SURE_OK { get; set; }

        public DateTime? CHECK_DATE { get; set; }

        [StringLength(50)]
        public string CHECK_NAME { get; set; }

        public DateTime? EPACHECK_DATE { get; set; }

        [StringLength(50)]
        public string EPACHECK_NAME { get; set; }

        [StringLength(255)]
        public string Exp { get; set; }

        public int? CASH { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        [StringLength(50)]
        public string ContactPhone2 { get; set; }

        public int? SUP_Status { get; set; }

        public int? Temporary_Status { get; set; }

        public int? EPA_ReadOrNot { get; set; }

        public int? PType { get; set; }

        public int? Check1 { get; set; }

        [StringLength(300)]
        public string CheckText1 { get; set; }

        public int? Check2 { get; set; }

        [StringLength(300)]
        public string CheckText2 { get; set; }

        public int? Check3 { get; set; }

        [StringLength(300)]
        public string CheckText3 { get; set; }

        [StringLength(300)]
        public string image1 { get; set; }

        [StringLength(300)]
        public string image2 { get; set; }

        [StringLength(300)]
        public string image3 { get; set; }

        [StringLength(300)]
        public string image4 { get; set; }

        [StringLength(300)]
        public string image1_expand { get; set; }

        [StringLength(300)]
        public string image2_expand { get; set; }

        [StringLength(300)]
        public string image3_expand { get; set; }

        [StringLength(300)]
        public string image4_expand { get; set; }
    }
}
