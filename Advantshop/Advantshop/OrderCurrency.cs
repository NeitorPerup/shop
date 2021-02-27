namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderCurrency")]
    public partial class OrderCurrency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        public int CurrencyNumCode { get; set; }

        public double CurrencyValue { get; set; }

        [Required]
        [StringLength(7)]
        public string CurrencySymbol { get; set; }

        public bool IsCodeBefore { get; set; }

        public double RoundNumbers { get; set; }

        public bool EnablePriceRounding { get; set; }

        public virtual Order1 Order1 { get; set; }
    }
}
