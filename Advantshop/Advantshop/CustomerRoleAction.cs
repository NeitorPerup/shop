namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.CustomerRoleAction")]
    public partial class CustomerRoleAction
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RoleActionKey { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Enabled { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
