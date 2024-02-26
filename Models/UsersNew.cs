namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersNew")]
    public partial class UsersNew
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Pwd { get; set; }

        [StringLength(30)]
        public string VoicePwd { get; set; }

        [StringLength(30)]
        public string Duty { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(30)]
        public string Town { get; set; }

        [StringLength(20)]
        public string MobilePhone { get; set; }

        [StringLength(10)]
        public string HumanType { get; set; }

        [StringLength(2)]
        public string MainContacter { get; set; }

        public string ReportPriority { get; set; }

        public int? DepartmentId { get; set; }

        public int? PositionId { get; set; }

        [StringLength(30)]
        public string OfficePhone { get; set; }

        [StringLength(50)]
        public string FaxNumber { get; set; }

        public string Email { get; set; }

        public string Remark { get; set; }

        [StringLength(30)]
        public string HomeNumber { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? CityId { get; set; }

        public int? TownId { get; set; }

        public int? DutyId { get; set; }

        public DateTime? ConfirmTime { get; set; }

        public bool? isadmin { get; set; }

        public int? ContactManualDuty { get; set; }

        public int? ContactManualDepartmentId { get; set; }
    }
}
