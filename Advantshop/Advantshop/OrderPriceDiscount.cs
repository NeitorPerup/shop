namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderPriceDiscount")]
    public partial class OrderPriceDiscount
    {
        public int OrderPriceDiscountID { get; set; }

        public double PriceRange { get; set; }

        public double PercentDiscount { get; set; }
    }
}
