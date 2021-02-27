namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.AffiliateSmsTemplate")]
    public partial class AffiliateSmsTemplate
    {
        public int Id { get; set; }

        public int AffiliateId { get; set; }

        public byte Status { get; set; }

        [StringLength(500)]
        public string Text { get; set; }

        public bool Enabled { get; set; }

        public virtual Affiliate Affiliate { get; set; }
    }
}
