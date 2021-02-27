namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.AffiliateReservationResource")]
    public partial class AffiliateReservationResource
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AffiliateId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReservationResourceId { get; set; }

        public int? BookingIntervalMinutes { get; set; }

        public virtual Affiliate Affiliate { get; set; }

        public virtual ReservationResource ReservationResource { get; set; }
    }
}
