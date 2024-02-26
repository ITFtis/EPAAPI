namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfirmTime")]
    public partial class ConfirmTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public DateTime? CityId { get; set; }

        public DateTime? Disinfector { get; set; }

        public DateTime? Disinfectant { get; set; }

        public DateTime? Dump { get; set; }

        public DateTime? Toilet { get; set; }

        public DateTime? Users { get; set; }

        public DateTime? Landfill { get; set; }

        public DateTime? Incinerator { get; set; }

        public DateTime? District { get; set; }

        public DateTime? Volunteer { get; set; }
    }
}
