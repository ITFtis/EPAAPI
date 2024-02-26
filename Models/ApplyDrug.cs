namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApplyDrug")]
    public partial class ApplyDrug
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string DiasterId { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Town { get; set; }

        [StringLength(20)]
        public string Thing { get; set; }

        public int? Count { get; set; }

        [StringLength(20)]
        public string NeedDay { get; set; }

        public string DiasterRegionDescribe { get; set; }

        public string DiasterPictureDescribe { get; set; }

        [StringLength(20)]
        public string ReportMan { get; set; }

        [StringLength(20)]
        public string ReportPhone { get; set; }

        [StringLength(20)]
        public string ReportMobilePhone { get; set; }

        [StringLength(20)]
        public string ConfirmTime { get; set; }

        [StringLength(20)]
        public string ReportTime { get; set; }

        [StringLength(20)]
        public string UpdateTime { get; set; }
    }
}
