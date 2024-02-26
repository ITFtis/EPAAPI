namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactManulTYpe")]
    public partial class ContactManulTYpe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        public string TypeName { get; set; }
    }
}
