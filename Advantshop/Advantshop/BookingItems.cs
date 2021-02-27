namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.BookingItems")]
    public partial class BookingItems
    {
        public int Id { get; set; }

        public int BookingId { get; set; }

        public int? ServiceId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public double Price { get; set; }

        public double Amount { get; set; }

        [StringLength(100)]
        public string ArtNo { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Service Service { get; set; }
    }
}
