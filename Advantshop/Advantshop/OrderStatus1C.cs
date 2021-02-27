namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderStatus1C")]
    public partial class OrderStatus1C
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Status1C { get; set; }

        [Key]
        [Column(Order = 2)]
        public string OrderId1C { get; set; }

        [Key]
        [Column(Order = 3)]
        public string OrderDate { get; set; }
    }
}
