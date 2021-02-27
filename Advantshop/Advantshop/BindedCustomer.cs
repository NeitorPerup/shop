namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partners.BindedCustomer")]
    public partial class BindedCustomer
    {
        public int PartnerId { get; set; }

        [Key]
        public Guid CustomerId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        [StringLength(500)]
        public string UrlReferrer { get; set; }

        [StringLength(500)]
        public string UtmSource { get; set; }

        [StringLength(500)]
        public string UtmMedium { get; set; }

        [StringLength(500)]
        public string UtmCampaign { get; set; }

        [StringLength(500)]
        public string UtmTerm { get; set; }

        [StringLength(500)]
        public string UtmContent { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        [StringLength(50)]
        public string CouponCode { get; set; }

        public bool Enabled { get; set; }

        public DateTime? VisitDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Partner Partner { get; set; }
    }
}
