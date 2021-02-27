namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.ShippingCache")]
    public partial class ShippingCache
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShippingMethodID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParamHash { get; set; }

        [Required]
        public string Options { get; set; }

        public DateTime Created { get; set; }

        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
