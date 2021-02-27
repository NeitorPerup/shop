namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.RelatedProducts")]
    public partial class RelatedProducts
    {
        [Key]
        public int RelatedProductID { get; set; }

        public int ProductID { get; set; }

        public int LinkedProductID { get; set; }

        public int RelatedType { get; set; }

        public int SortOrder { get; set; }
    }
}
