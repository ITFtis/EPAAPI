namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemConfigSetting")]
    public partial class SystemConfigSetting
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FunctionId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Value { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime CreateTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime UpdateTime { get; set; }
    }
}
