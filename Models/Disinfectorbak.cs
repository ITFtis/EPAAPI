namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Disinfectorbak")]
    public partial class Disinfectorbak
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(30)]
        public string ContactUnit { get; set; }

        [StringLength(100)]
        public string DisinfectInstrument { get; set; }

        [StringLength(100)]
        public string Standard { get; set; }

        public int? Amount { get; set; }

        [StringLength(3)]
        public string ROCyear { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? ConfirmTime { get; set; }

        public int? UseType { get; set; }
    }
}
