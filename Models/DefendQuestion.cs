namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DefendQuestion")]
    public partial class DefendQuestion
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DefendId { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Ans { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime UpdateDate { get; set; }
    }
}
