namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderCustomOptions")]
    public partial class OrderCustomOptions
    {
        public int OrderCustomOptionsId { get; set; }

        public int CustomOptionId { get; set; }

        public int OptionId { get; set; }

        [Required]
        [StringLength(255)]
        public string CustomOptionTitle { get; set; }

        [Required]
        [StringLength(255)]
        public string OptionTitle { get; set; }

        [Column(TypeName = "money")]
        public decimal OptionPriceBC { get; set; }

        public int OptionPriceType { get; set; }

        public int OrderedCartID { get; set; }

        public virtual OrderItems OrderItems { get; set; }
    }
}
