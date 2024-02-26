namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShiftSchedule")]
    public partial class ShiftSchedule
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentId { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsNight { get; set; }

        public int? DiasterId { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime Date { get; set; }
    }
}
