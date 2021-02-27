namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.PaymentMethod")]
    public partial class PaymentMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentMethod()
        {
            Booking = new HashSet<Booking>();
            Order1 = new HashSet<Order1>();
            OrderPaymentInfo = new HashSet<OrderPaymentInfo>();
            PaymentParam = new HashSet<PaymentParam>();
            ShippingPayments = new HashSet<ShippingPayments>();
            City = new HashSet<City>();
            Country = new HashSet<Country>();
        }

        public int PaymentMethodID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool Enabled { get; set; }

        public int SortOrder { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(50)]
        public string PaymentType { get; set; }

        public double? Extracharge { get; set; }

        public int? ExtrachargeType { get; set; }

        public int? CurrencyId { get; set; }

        public int? TaxId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order1> Order1 { get; set; }

        public virtual GiftCertificatePayments GiftCertificatePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPaymentInfo> OrderPaymentInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentParam> PaymentParam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingPayments> ShippingPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Country> Country { get; set; }
    }
}
