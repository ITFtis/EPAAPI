namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Volunteer")]
    public partial class Volunteer
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(10)]
        public string ContactPerson { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string MobilePhone { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        public string Mail { get; set; }

        public string Service { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? ConfirmTime { get; set; }
    }
}
