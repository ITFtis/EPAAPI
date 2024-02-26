namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactManualRoleBak")]
    public partial class ContactManualRoleBak
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreateDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime UpdateDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string UpdateUser { get; set; }
    }
}
