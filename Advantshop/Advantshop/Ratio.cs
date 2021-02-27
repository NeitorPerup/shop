namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Ratio")]
    public partial class Ratio
    {
        public int RatioID { get; set; }

        public int ProductID { get; set; }

        public int ProductRatio { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime AddDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
