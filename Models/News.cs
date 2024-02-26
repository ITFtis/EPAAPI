namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiasterId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Content { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime UpdateDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string UpdateUser { get; set; }
    }
}
