namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Damage")]
    public partial class Damage
    {
        public int Id { get; set; }

        public int? DiasterId { get; set; }

        public int? CityId { get; set; }

        public int? TownId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReportDay { get; set; }

        [StringLength(300)]
        public string DamagePlace { get; set; }

        public decimal? DamageArea { get; set; }

        public decimal? FloodArea { get; set; }

        [StringLength(300)]
        public string DumpSiteDesc { get; set; }

        [StringLength(250)]
        public string IncinerationPlantDesc { get; set; }

        [StringLength(250)]
        public string Other { get; set; }

        public DateTime? DisinfectDate { get; set; }

        public decimal? DisinfectArea { get; set; }

        public decimal? PR_Garbage { get; set; }

        public decimal? CLE_Disinfect { get; set; }

        public decimal? CLE_MUD { get; set; }

        public decimal? CLE_Trash { get; set; }

        public int? CleaningMemberQuantity { get; set; }

        public int? NationalArmyQuantity { get; set; }

        public int? ImageFileId { get; set; }

        public int? FileId { get; set; }

        public DateTime? ConfirmTime { get; set; }

        public int? Status { get; set; }

        public int? DutyId { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string ADMIT { get; set; }

        [StringLength(50)]
        public string COUNTY_NAME { get; set; }

        public long? PRE_INDEX { get; set; }

        [StringLength(200)]
        public string IncineratorIds { get; set; }

        [StringLength(200)]
        public string LandfillIds { get; set; }

        [StringLength(500)]
        public string ProcessDesc { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public bool? IsDamage { get; set; }

        public decimal? CLE_Garbage { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TeamConfirmTime { get; set; }
    }
}
