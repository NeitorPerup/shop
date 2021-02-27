namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.ShippingParam")]
    public partial class ShippingParam
    {
        public int ShippingParamID { get; set; }

        public int ShippingMethodID { get; set; }

        [Required]
        [StringLength(250)]
        public string ParamName { get; set; }

        [Required]
        public string ParamValue { get; set; }

        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
