namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.ProductVideo")]
    public partial class ProductVideo
    {
        public int ProductVideoID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string PlayerCode { get; set; }

        public string Description { get; set; }

        public int? VideoSortOrder { get; set; }

        public virtual Product Product { get; set; }
    }
}
