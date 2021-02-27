namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.ShippingReplaceGeo")]
    public partial class ShippingReplaceGeo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ShippingType { get; set; }

        [Required]
        [StringLength(70)]
        public string InCountryName { get; set; }

        [Required]
        [StringLength(2)]
        public string InCountryISO2 { get; set; }

        [Required]
        [StringLength(70)]
        public string InRegionName { get; set; }

        [Required]
        [StringLength(255)]
        public string InCityName { get; set; }

        [Required]
        [StringLength(255)]
        public string InDistrict { get; set; }

        [Required]
        [StringLength(70)]
        public string OutCountryName { get; set; }

        [Required]
        [StringLength(70)]
        public string OutRegionName { get; set; }

        [Required]
        [StringLength(255)]
        public string OutCityName { get; set; }

        [Required]
        [StringLength(255)]
        public string OutDistrict { get; set; }

        public bool OutDistrictClear { get; set; }

        public bool Enabled { get; set; }

        public int Sort { get; set; }

        [Required]
        [StringLength(70)]
        public string InZip { get; set; }

        [Required]
        [StringLength(70)]
        public string OutZip { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }
    }
}
