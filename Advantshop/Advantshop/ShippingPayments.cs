namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.ShippingPayments")]
    public partial class ShippingPayments
    {
        public int ShippingMethodID { get; set; }

        public int PaymentMethodID { get; set; }

        public int id { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
