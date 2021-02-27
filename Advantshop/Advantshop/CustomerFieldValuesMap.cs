namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.CustomerFieldValuesMap")]
    public partial class CustomerFieldValuesMap
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerFieldId { get; set; }

        [Required]
        public string Value { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CustomerField CustomerField { get; set; }
    }
}
