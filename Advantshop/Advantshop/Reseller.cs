namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.Reseller")]
    public partial class Reseller
    {
        public Guid ResellerID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public double PurchaseDiscount { get; set; }

        public double RecommendedPriceMargin { get; set; }

        public bool ExportOnlyActiveProducts { get; set; }
    }
}
