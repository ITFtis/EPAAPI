namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [StringLength(3)]
        public string Id { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Place1 { get; set; }

        [StringLength(30)]
        public string Line1 { get; set; }

        [StringLength(30)]
        public string Phone1 { get; set; }

        [StringLength(30)]
        public string Fax1 { get; set; }

        public string Mail1 { get; set; }

        [StringLength(30)]
        public string Place2 { get; set; }

        [StringLength(30)]
        public string Line2 { get; set; }

        [StringLength(30)]
        public string Phone2 { get; set; }

        [StringLength(30)]
        public string Fax2 { get; set; }

        [StringLength(30)]
        public string Mail2 { get; set; }

        [StringLength(30)]
        public string Place3 { get; set; }

        [StringLength(30)]
        public string Line3 { get; set; }

        [StringLength(30)]
        public string Phone3 { get; set; }

        [StringLength(30)]
        public string Fax3 { get; set; }

        [StringLength(30)]
        public string Mail3 { get; set; }
    }
}
