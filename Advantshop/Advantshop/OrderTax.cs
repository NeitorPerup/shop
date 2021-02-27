namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderTax")]
    public partial class OrderTax
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxId { get; set; }

        [Required]
        [StringLength(250)]
        public string TaxName { get; set; }

        public double TaxSum { get; set; }

        public bool TaxShowInPrice { get; set; }

        public double TaxRate { get; set; }

        public virtual Order1 Order1 { get; set; }
    }
}
