namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderContact")]
    public partial class OrderContact
    {
        public int OrderContactID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(70)]
        public string Country { get; set; }

        [Required]
        [StringLength(70)]
        public string Zone { get; set; }

        [StringLength(70)]
        public string City { get; set; }

        [StringLength(70)]
        public string Zip { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public string CustomField1 { get; set; }

        public string CustomField2 { get; set; }

        public string CustomField3 { get; set; }
    }
}
