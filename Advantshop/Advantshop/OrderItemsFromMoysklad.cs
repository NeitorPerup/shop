namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderItemsFromMoysklad")]
    public partial class OrderItemsFromMoysklad
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string OfferExternalId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderItemID { get; set; }

        public virtual OrderItems OrderItems { get; set; }
    }
}
