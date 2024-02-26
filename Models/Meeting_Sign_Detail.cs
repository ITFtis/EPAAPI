namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Meeting_Sign_Detail
    {
        [Key]
        [Column(Order = 0)]
        public int Row_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Meeting_ID { get; set; }

        [StringLength(50)]
        public string Unit_name { get; set; }

        [StringLength(50)]
        public string Duties { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Sex { get; set; }

        [StringLength(50)]
        public string Birthday { get; set; }

        [StringLength(20)]
        public string ID_Number { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string CellPhone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Beneficiary { get; set; }

        [StringLength(200)]
        public string BeneficiaryRel { get; set; }

        [StringLength(10)]
        public string Stay { get; set; }

        [StringLength(200)]
        public string Traffic_Go { get; set; }

        [StringLength(200)]
        public string Traffic_Back { get; set; }

        [StringLength(4000)]
        public string Memo { get; set; }

        [StringLength(100)]
        public string Meals { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public DateTime? Keyin_date { get; set; }

        [StringLength(50)]
        public string Source_IP { get; set; }

        [StringLength(100)]
        public string part { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Town { get; set; }
    }
}
