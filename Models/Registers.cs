namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Registers
    {
        [StringLength(14)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Pwd { get; set; }

        [StringLength(50)]
        public string VoicePwd { get; set; }

        [StringLength(30)]
        public string Duty { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(200)]
        public string HumanType { get; set; }

        [StringLength(2)]
        public string MainContacter { get; set; }

        [StringLength(2)]
        public string ReportPriority { get; set; }

        public int? CityId { get; set; }

        public int? TownId { get; set; }

        public int? DutyId { get; set; }

        public int? PositionId { get; set; }

        [StringLength(200)]
        public string OfficePhone { get; set; }

        [StringLength(200)]
        public string Email { get; set; }
    }
}
