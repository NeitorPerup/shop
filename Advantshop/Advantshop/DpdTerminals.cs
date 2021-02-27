namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.DpdTerminals")]
    public partial class DpdTerminals
    {
        [Key]
        [StringLength(255)]
        public string Code { get; set; }

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

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public bool IsSelfPickup { get; set; }

        public bool IsSelfDelivery { get; set; }

        [StringLength(255)]
        public string SelfDeliveryTimes { get; set; }

        [Required]
        [StringLength(100)]
        public string ExtraServices { get; set; }

        [Required]
        [StringLength(100)]
        public string Services { get; set; }

        public string AddressDescription { get; set; }
    }
}
