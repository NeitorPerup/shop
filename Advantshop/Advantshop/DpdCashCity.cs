namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.DpdCashCity")]
    public partial class DpdCashCity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CityId { get; set; }

        [Required]
        [StringLength(255)]
        public string CityName { get; set; }

        [Required]
        [StringLength(255)]
        public string RegionName { get; set; }

        [Required]
        [StringLength(2)]
        public string CountryCode { get; set; }

        [StringLength(50)]
        public string Abbreviation { get; set; }
    }
}
