namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRASH_BURN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public double? AREA { get; set; }

        [StringLength(10)]
        public string ADMIT_ID { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(10)]
        public string COUNTY_ID { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        public double? PERIMETER { get; set; }

        public double? GARB2_ { get; set; }

        public double? GARB2_ID { get; set; }

        public double? TYPE { get; set; }

        public double? CODE { get; set; }

        [StringLength(60)]
        public string GNAME { get; set; }

        [StringLength(60)]
        public string GADDR { get; set; }

        [StringLength(60)]
        public string SERVICE { get; set; }

        [StringLength(60)]
        public string MANAGE { get; set; }

        [StringLength(60)]
        public string UNITNAME { get; set; }

        [StringLength(60)]
        public string UNITADDR { get; set; }

        [StringLength(60)]
        public string UNITTEL { get; set; }

        [StringLength(60)]
        public string CONTAC { get; set; }

        [StringLength(60)]
        public string CONT { get; set; }

        [StringLength(60)]
        public string CONTTEL { get; set; }

        [StringLength(60)]
        public string ENV { get; set; }

        [StringLength(60)]
        public string A14 { get; set; }

        public double? AREA_HA { get; set; }

        [StringLength(60)]
        public string ASHADDR { get; set; }

        [StringLength(60)]
        public string A16 { get; set; }

        public double? SYY { get; set; }

        public double? SMM { get; set; }

        public double? SDD { get; set; }

        [StringLength(60)]
        public string A17 { get; set; }

        public double? USEYEAR { get; set; }

        [StringLength(60)]
        public string A18 { get; set; }

        public double? PROCESS { get; set; }

        [StringLength(60)]
        public string A19 { get; set; }

        public double? OUTASH { get; set; }

        [StringLength(60)]
        public string ACCDESC { get; set; }

        [StringLength(1)]
        public string ACCID { get; set; }

        [StringLength(60)]
        public string MAPNO { get; set; }

        public double? TEMPID { get; set; }

        public double? X_COORD { get; set; }

        public double? Y_COORD { get; set; }

        public double? AVGPR { get; set; }

        public double? ACCNO { get; set; }

        [StringLength(60)]
        public string REASON { get; set; }

        [StringLength(128)]
        public string IMAGE1 { get; set; }

        [StringLength(128)]
        public string IMAGE2 { get; set; }

        [StringLength(128)]
        public string IMAGE3 { get; set; }

        [StringLength(128)]
        public string IMAGE4 { get; set; }

        [StringLength(128)]
        public string IMAGE5 { get; set; }

        [StringLength(128)]
        public string IMAGE6 { get; set; }

        [StringLength(81)]
        public string SGNAME { get; set; }

        [StringLength(13)]
        public string SADMINAME1 { get; set; }

        [StringLength(21)]
        public string SADMINAME2 { get; set; }

        [StringLength(16)]
        public string ADMINAME3 { get; set; }

        public double? TM2_X { get; set; }

        public double? TM2_Y { get; set; }

        public double? DD_X { get; set; }

        public double? DD_Y { get; set; }

        [StringLength(50)]
        public string CreateId { get; set; }

        public DateTime? CreateDt { get; set; }

        [StringLength(50)]
        public string UpdateId { get; set; }

        public DateTime? UpdateDt { get; set; }

        public DateTime? VALID_DATE2 { get; set; }
    }
}
