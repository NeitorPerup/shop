namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderStatus")]
    public partial class OrderStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderStatus()
        {
            Order1 = new HashSet<Order1>();
            SmsTemplateOnOrderChanging = new HashSet<SmsTemplateOnOrderChanging>();
        }

        public int OrderStatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        public byte CommandID { get; set; }

        public bool IsDefault { get; set; }

        public bool IsCanceled { get; set; }

        [StringLength(10)]
        public string Color { get; set; }

        public int SortOrder { get; set; }

        public bool IsCompleted { get; set; }

        public bool? Hidden { get; set; }

        public bool CancelForbidden { get; set; }

        public bool? ShowInMenu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order1> Order1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SmsTemplateOnOrderChanging> SmsTemplateOnOrderChanging { get; set; }
    }
}
