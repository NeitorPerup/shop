namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Coupon")]
    public partial class Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coupon()
        {
            CustomerCoupon = new HashSet<CustomerCoupon>();
            Partner = new HashSet<Partner>();
            Category1 = new HashSet<Category1>();
            Customer = new HashSet<Customer>();
            Product = new HashSet<Product>();
        }

        public int CouponID { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public int Type { get; set; }

        public double Value { get; set; }

        public DateTime AddingDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int PossibleUses { get; set; }

        public int ActualUses { get; set; }

        public bool Enabled { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinimalOrderPrice { get; set; }

        [StringLength(3)]
        public string CurrencyIso3 { get; set; }

        public int? TriggerId { get; set; }

        public int? Mode { get; set; }

        public int? TriggerActionId { get; set; }

        public int? Days { get; set; }

        public Guid? CustomerId { get; set; }

        public DateTime? StartDate { get; set; }

        public bool ForFirstOrder { get; set; }

        public int? EntityId { get; set; }

        public bool? IsMinimalOrderPriceFromAllCart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerCoupon> CustomerCoupon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partner> Partner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category1> Category1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
