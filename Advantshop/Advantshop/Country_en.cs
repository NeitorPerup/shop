namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Country_en")]
    public partial class Country_en
    {
        [Key]
        [Column(Order = 0)]
        public int CountryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string CountryName { get; set; }

        [StringLength(2)]
        public string CountryISO2 { get; set; }

        [StringLength(3)]
        public string CountryISO3 { get; set; }
    }
}
