namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderItems")]
    public partial class OrderItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItems()
        {
            OrderCustomOptions = new HashSet<OrderCustomOptions>();
            OrderItemsFromMoysklad = new HashSet<OrderItemsFromMoysklad>();
        }

        [Key]
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public double Price { get; set; }

        public double Amount { get; set; }

        [Required]
        [StringLength(100)]
        public string ArtNo { get; set; }

        public double SupplyPrice { get; set; }

        public double Weight { get; set; }

        public bool IsCouponApplied { get; set; }

        [StringLength(300)]
        public string Color { get; set; }

        [StringLength(300)]
        public string Size { get; set; }

        public double DecrementedAmount { get; set; }

        public int? PhotoID { get; set; }

        public bool IgnoreOrderDiscount { get; set; }

        public bool AccrueBonuses { get; set; }

        public int? TaxId { get; set; }

        [StringLength(50)]
        public string TaxName { get; set; }

        public int? TaxType { get; set; }

        public double? TaxRate { get; set; }

        public bool? TaxShowInPrice { get; set; }

        public double? Length { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }

        public int PaymentSubjectType { get; set; }

        public int PaymentMethodType { get; set; }

        public bool? IsGift { get; set; }

        public int? BookingServiceId { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeItem { get; set; }

        public virtual Service Service { get; set; }

        public virtual Photo Photo { get; set; }

        public virtual Product Product { get; set; }

        public virtual Order1 Order1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCustomOptions> OrderCustomOptions { get; set; }

        public virtual OrderItems OrderItems1 { get; set; }

        public virtual OrderItems OrderItems2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemsFromMoysklad> OrderItemsFromMoysklad { get; set; }
    }
}
