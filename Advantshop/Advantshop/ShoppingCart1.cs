namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.ShoppingCart")]
    public partial class ShoppingCart1
    {
        [Key]
        public int ShoppingCartItemId { get; set; }

        public int ShoppingCartType { get; set; }

        public Guid CustomerId { get; set; }

        public int OfferId { get; set; }

        [Required]
        public string AttributesXml { get; set; }

        public double Amount { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool? IsGift { get; set; }

        [StringLength(50)]
        public string ModuleKey { get; set; }

        public bool AddedByRequest { get; set; }

        public double? CustomPrice { get; set; }

        public virtual Offer Offer { get; set; }
    }
}
