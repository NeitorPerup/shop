namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.ShippingMethod")]
    public partial class ShippingMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShippingMethod()
        {
            Order1 = new HashSet<Order1>();
            ShippingCache = new HashSet<ShippingCache>();
            ShippingParam = new HashSet<ShippingParam>();
            ShippingPayments = new HashSet<ShippingPayments>();
            Category1 = new HashSet<Category1>();
            City = new HashSet<City>();
            City1 = new HashSet<City>();
            Country = new HashSet<Country>();
            Country1 = new HashSet<Country>();
            Product = new HashSet<Product>();
            Region = new HashSet<Region>();
            Region1 = new HashSet<Region>();
        }

        public int ShippingMethodID { get; set; }

        [StringLength(50)]
        public string ShippingType { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Enabled { get; set; }

        public int SortOrder { get; set; }

        public bool? DisplayCustomFields { get; set; }

        public bool ShowInDetails { get; set; }

        [StringLength(255)]
        public string ZeroPriceMessage { get; set; }

        public bool? DisplayIndex { get; set; }

        public int? TaxId { get; set; }

        public int? ExtrachargeType { get; set; }

        public double? Extracharge { get; set; }

        public bool? ExtrachargeFromOrder { get; set; }

        public int? ExtraDeliveryTime { get; set; }

        public bool? MoveToEnd { get; set; }

        public bool? ShowIfNoOtherShippings { get; set; }

        public int? CurrencyId { get; set; }

        [StringLength(150)]
        public string ModuleStringId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order1> Order1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingCache> ShippingCache { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingParam> ShippingParam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingPayments> ShippingPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category1> Category1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> City1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Country> Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Country> Country1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Region> Region { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Region> Region1 { get; set; }
    }
}
