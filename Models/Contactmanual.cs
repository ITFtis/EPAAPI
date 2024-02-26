namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contactmanual")]
    public partial class Contactmanual
    {
        public int ID { get; set; }

        public int? Type { get; set; }

        public int? SourceId { get; set; }

        [StringLength(30)]
        public string UserId { get; set; }

        [StringLength(256)]
        public string Note { get; set; }

        public int? RoleId { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(30)]
        public string CreateUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(30)]
        public string UpdateUser { get; set; }

        public int? Sort { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
