namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dump")]
    public partial class Dump
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ContactUnit { get; set; }

        public decimal? Xpos { get; set; }

        public decimal? Ypos { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(20)]
        public string UpdateTime { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Area { get; set; }

        [StringLength(20)]
        public string EmergencyContactPerson { get; set; }

        [StringLength(20)]
        public string EmergencyContactPersonTitle { get; set; }

        [StringLength(50)]
        public string EmergencyMobilePhone { get; set; }

        [StringLength(50)]
        public string EmergencyPhoneDay { get; set; }

        [StringLength(50)]
        public string EmergencyPhoneNight { get; set; }

        public DateTime? ConfirmTime { get; set; }
    }
}
