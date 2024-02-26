namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Emis
    {
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(20)]
        public string VoicePwd { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
    }
}
