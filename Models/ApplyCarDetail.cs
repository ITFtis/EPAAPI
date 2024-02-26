namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyCarDetail")]
    public partial class ApplyCarDetail
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplyCarId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplyCarTypeId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Quantity { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string PrefectureDescription { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string NearPrefectureDescription { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string OpenContractDescription { get; set; }
    }
}
