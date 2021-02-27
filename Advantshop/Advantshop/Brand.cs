namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Brand")]
    public partial class Brand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Brand()
        {
            Product = new HashSet<Product>();
        }

        public int BrandID { get; set; }

        [Required]
        public string BrandName { get; set; }

        public string BrandDescription { get; set; }

        public bool Enabled { get; set; }

        public int? CountryID { get; set; }

        public int? SortOrder { get; set; }

        [StringLength(150)]
        public string UrlPath { get; set; }

        public string BrandBriefDescription { get; set; }

        [StringLength(150)]
        public string BrandSiteUrl { get; set; }

        public bool? IsDemo { get; set; }

        public int? CountryOfManufactureID { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
