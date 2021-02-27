namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.ShoppingCart")]
    public partial class ShoppingCart
    {
        [Key]
        public int ShoppingCartItemId { get; set; }

        public Guid CustomerId { get; set; }

        public int AffiliateId { get; set; }

        public int? ReservationResourceId { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string Services { get; set; }

        public virtual Affiliate Affiliate { get; set; }

        public virtual ReservationResource ReservationResource { get; set; }
    }
}
