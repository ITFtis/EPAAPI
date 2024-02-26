namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToiletCleaningLog")]
    public partial class ToiletCleaningLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToiletLocationId { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsClean { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string UpdateUser { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UpdateDate { get; set; }
    }
}
