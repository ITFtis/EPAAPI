namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileData")]
    public partial class FileData
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SourceId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SourceType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string RealFileName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string UserFileName { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string CreateUser { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
