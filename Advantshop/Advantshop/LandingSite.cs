namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingSite")]
    public partial class LandingSite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LandingSite()
        {
            LandingDomain = new HashSet<LandingDomain>();
            LandingSiteSettings = new HashSet<LandingSiteSettings>();
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(260)]
        public string Name { get; set; }

        public bool Enabled { get; set; }

        [Required]
        public string Template { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string DomainUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ProductId { get; set; }

        public int? AdditionalSalesProductId { get; set; }

        public string ScreenShot { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? ScreenShotDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingDomain> LandingDomain { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingSiteSettings> LandingSiteSettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
