namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.CustomerFieldValue")]
    public partial class CustomerFieldValue
    {
        public int Id { get; set; }

        public int CustomerFieldId { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public int SortOrder { get; set; }

        public virtual CustomerField CustomerField { get; set; }
    }
}
