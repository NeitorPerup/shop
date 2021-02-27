namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.Order")]
    public partial class Order1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order1()
        {
            Booking = new HashSet<Booking>();
            ManagerTask = new HashSet<ManagerTask>();
            Task = new HashSet<Task>();
            Certificate = new HashSet<Certificate>();
            OrderAdditionalData = new HashSet<OrderAdditionalData>();
            DDeliveryOrders = new HashSet<DDeliveryOrders>();
            OrderItems = new HashSet<OrderItems>();
            OrderPaymentInfo = new HashSet<OrderPaymentInfo>();
            OrderTax = new HashSet<OrderTax>();
            Transaction1 = new HashSet<Transaction1>();
            VkOrder_Order = new HashSet<VkOrder_Order>();
        }

        [Key]
        public int OrderID { get; set; }

        [Required]
        [StringLength(25)]
        public string Number { get; set; }

        public int? ShippingMethodID { get; set; }

        public int? PaymentMethodID { get; set; }

        public int? AffiliateID { get; set; }

        public double? OrderDiscount { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? PaymentDate { get; set; }

        [StringLength(255)]
        public string GroupName { get; set; }

        public double? GroupDiscount { get; set; }

        public string CustomerComment { get; set; }

        [Required]
        public string StatusComment { get; set; }

        public string AdditionalTechInfo { get; set; }

        public string AdminOrderComment { get; set; }

        public bool Decremented { get; set; }

        public double ShippingCost { get; set; }

        public double TaxCost { get; set; }

        public double SupplyTotal { get; set; }

        public double Sum { get; set; }

        public int OrderStatusID { get; set; }

        public int ShippingContactID { get; set; }

        public int BillingContactID { get; set; }

        [StringLength(255)]
        public string PaymentMethodName { get; set; }

        [StringLength(255)]
        public string ShippingMethodName { get; set; }

        [StringLength(50)]
        public string CertificateCode { get; set; }

        public double? CertificatePrice { get; set; }

        [StringLength(50)]
        public string CouponCode { get; set; }

        public int? CouponType { get; set; }

        public double? CouponValue { get; set; }

        public double? PaymentCost { get; set; }

        public double? BonusCost { get; set; }

        public double? DiscountCost { get; set; }

        public bool? UseIn1C { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Guid Code { get; set; }

        public bool ManagerConfirmed { get; set; }

        public int? ManagerId { get; set; }

        [StringLength(100)]
        public string PreviousStatus { get; set; }

        public long? BonusCardNumber { get; set; }

        public int OrderSourceId { get; set; }

        public string CustomData { get; set; }

        [StringLength(255)]
        public string TrackNumber { get; set; }

        public bool? IsDraft { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(255)]
        public string DeliveryTime { get; set; }

        public bool? IsFromAdminArea { get; set; }

        public double? OrderDiscountValue { get; set; }

        public int? LeadId { get; set; }

        public int? ShippingTaxType { get; set; }

        public int? LpId { get; set; }

        public bool IsSendedToGA { get; set; }

        [StringLength(20)]
        public string PayCode { get; set; }

        public double? TotalWeight { get; set; }

        public double? TotalLength { get; set; }

        public double? TotalWidth { get; set; }

        public double? TotalHeight { get; set; }

        public bool? AvailablePaymentCashOnDelivery { get; set; }

        public bool? AvailablePaymentPickPoint { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagerTask> ManagerTask { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificate> Certificate { get; set; }

        public virtual Lead Lead { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderAdditionalData> OrderAdditionalData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDeliveryOrders> DDeliveryOrders { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual ShippingMethod ShippingMethod { get; set; }

        public virtual OrderCurrency OrderCurrency { get; set; }

        public virtual OrderCustomer OrderCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPaymentInfo> OrderPaymentInfo { get; set; }

        public virtual OrderPickPoint OrderPickPoint { get; set; }

        public virtual OrderSendMoysklad OrderSendMoysklad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderTax> OrderTax { get; set; }

        public virtual PaymentDetails1 PaymentDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction1> Transaction1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VkOrder_Order> VkOrder_Order { get; set; }
    }
}
