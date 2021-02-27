namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.ProductFile")]
    public partial class ProductFile
    {
        public Guid ProductFileID { get; set; }

        public int ProductID { get; set; }

        [Required]
        public string Filename { get; set; }

        public virtual Product Product { get; set; }
    }
}
