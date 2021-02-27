namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Brand = new HashSet<Brand>();
            Contact = new HashSet<Contact>();
            PaymentMethod = new HashSet<PaymentMethod>();
            ShippingMethod = new HashSet<ShippingMethod>();
            ShippingMethod1 = new HashSet<ShippingMethod>();
        }

        public int CountryID { get; set; }

        [Required]
        [StringLength(70)]
        public string CountryName { get; set; }

        [StringLength(2)]
        public string CountryISO2 { get; set; }

        [StringLength(3)]
        public string CountryISO3 { get; set; }

        public bool? DisplayInPopup { get; set; }

        public int? SortOrder { get; set; }

        public int? DialCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Brand> Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contact { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual Country Country2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentMethod> PaymentMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingMethod> ShippingMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingMethod> ShippingMethod1 { get; set; }
    }
}
