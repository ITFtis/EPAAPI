namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pest")]
    public partial class Pest
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string License { get; set; }

        [StringLength(10)]
        public string ContactPerson { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? ConfirmTime { get; set; }
    }
}
