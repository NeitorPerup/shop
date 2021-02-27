namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.OpenIdLinkCustomer")]
    public partial class OpenIdLinkCustomer
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string OpenIdIdentifier { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
