namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.ReservationResourceTimeOfBooking")]
    public partial class ReservationResourceTimeOfBooking
    {
        public int Id { get; set; }

        public int AffiliateId { get; set; }

        public int ReservationResourceId { get; set; }

        public byte DayOfWeek { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public virtual Affiliate Affiliate { get; set; }

        public virtual ReservationResource ReservationResource { get; set; }
    }
}
