namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Offer")]
    public partial class Offer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offer()
        {
            ProductGifts = new HashSet<ProductGifts>();
            ShoppingCart1 = new HashSet<ShoppingCart1>();
        }

        public int OfferID { get; set; }

        public int ProductID { get; set; }

        public double Amount { get; set; }

        public double Price { get; set; }

        public double SupplyPrice { get; set; }

        public int? ColorID { get; set; }

        public int? SizeID { get; set; }

        [Required]
        [StringLength(100)]
        public string ArtNo { get; set; }

        public bool Main { get; set; }

        public double? Length { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }

        public double? Weight { get; set; }

        public virtual Color Color { get; set; }

        public virtual Product Product { get; set; }

        public virtual Size Size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductGifts> ProductGifts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart1> ShoppingCart1 { get; set; }
    }
}
