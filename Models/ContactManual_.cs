namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactManual_
    {
        public int Id { get; set; }

        public int Type { get; set; }

        public int SourceId { get; set; }

        public int UserId { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public int? RoleId { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        [StringLength(50)]
        public string UpdateUser { get; set; }

        public int Sort { get; set; }
    }
}
