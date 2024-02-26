namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DamageMain")]
    public partial class DamageMain
    {
        public int Id { get; set; }

        public int DiasterId { get; set; }

        public int CityId { get; set; }

        public bool IsDone { get; set; }

        public DateTime DoneDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
