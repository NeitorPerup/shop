namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.AffiliateAdditionalTime")]
    public partial class AffiliateAdditionalTime
    {
        public int Id { get; set; }

        public int AffiliateId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsWork { get; set; }

        public virtual Affiliate Affiliate { get; set; }
    }
}
