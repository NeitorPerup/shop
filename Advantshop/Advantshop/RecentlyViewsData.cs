namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.RecentlyViewsData")]
    public partial class RecentlyViewsData
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public DateTime ViewDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
