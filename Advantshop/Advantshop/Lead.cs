namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.Lead")]
    public partial class Lead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lead()
        {
            LeadFieldValuesMap = new HashSet<LeadFieldValuesMap>();
            ManagerTask = new HashSet<ManagerTask>();
            Task = new HashSet<Task>();
            LeadEvent = new HashSet<LeadEvent>();
            LeadItem = new HashSet<LeadItem>();
            Order1 = new HashSet<Order1>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(50)]
        public string LeadStatus { get; set; }

        [Required]
        public string Comment { get; set; }

        public string AdminComment { get; set; }

        public Guid? CustomerId { get; set; }

        public int? ManagerId { get; set; }

        public DateTime CreatedDate { get; set; }

        public double? Discount { get; set; }

        public int OrderSourceId { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Patronymic { get; set; }

        public string Description { get; set; }

        public double? Sum { get; set; }

        public int? DealStatusId { get; set; }

        public double? DiscountValue { get; set; }

        public bool? IsFromAdminArea { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(255)]
        public string DeliveryTime { get; set; }

        public int? ShippingMethodId { get; set; }

        [StringLength(255)]
        public string ShippingName { get; set; }

        public double ShippingCost { get; set; }

        public string ShippingPickPoint { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int SortOrder { get; set; }

        public int? SalesFunnelId { get; set; }

        [StringLength(250)]
        public string Organization { get; set; }

        public string Title { get; set; }

        [StringLength(70)]
        public string Country { get; set; }

        [StringLength(70)]
        public string Region { get; set; }

        [StringLength(70)]
        public string City { get; set; }

        [StringLength(70)]
        public string Zip { get; set; }

        [StringLength(70)]
        public string District { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadFieldValuesMap> LeadFieldValuesMap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagerTask> ManagerTask { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadEvent> LeadEvent { get; set; }

        public virtual LeadCurrency LeadCurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadItem> LeadItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order1> Order1 { get; set; }
    }
}
