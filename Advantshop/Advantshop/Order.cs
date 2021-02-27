namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Cost { get; set; }

        public int Number { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(150)]
        public string Person { get; set; }
    }
}
