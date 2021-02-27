namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Country_ru")]
    public partial class Country_ru
    {
        [Key]
        public int CountryID { get; set; }

        [Required]
        [StringLength(255)]
        public string CountryName { get; set; }

        [StringLength(2)]
        public string CountryISO2 { get; set; }

        [StringLength(3)]
        public string CountryISO3 { get; set; }
    }
}
