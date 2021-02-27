namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderConfirmation")]
    public partial class OrderConfirmation
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required]
        public string OrderConfirmationData { get; set; }

        public DateTime? LastUpdate { get; set; }
    }
}
