namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenContract")]
    public partial class OpenContract
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime KeyInDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OContractDateBegin { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime OContractDateEnd { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Fac { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Owner { get; set; }

        [StringLength(50)]
        public string TEL { get; set; }

        [StringLength(50)]
        public string MobileTEL { get; set; }

        public int? Status { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string UpdateUser { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResourceTypeId { get; set; }

        public int? CityId { get; set; }

        public int? TownId { get; set; }

        [StringLength(50)]
        public string PART1 { get; set; }

        [StringLength(50)]
        public string PART2 { get; set; }
    }
}
