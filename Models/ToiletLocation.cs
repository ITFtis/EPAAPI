namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToiletLocation")]
    public partial class ToiletLocation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiasterId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ManagementTownId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TownId { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Xpos { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal Ypos { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToiletQuantity { get; set; }

        [StringLength(20)]
        public string ToiletType { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "date")]
        public DateTime EndDate { get; set; }

        [StringLength(20)]
        public string ContactPerson { get; set; }

        [StringLength(200)]
        public string ContactMethod { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string UpdateUser { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime UpdateDate { get; set; }
    }
}
