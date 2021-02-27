namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderPaymentInfo")]
    public partial class OrderPaymentInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentMethodID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string Value { get; set; }

        public virtual Order1 Order1 { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
