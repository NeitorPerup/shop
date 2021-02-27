namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.TagMap")]
    public partial class TagMap1
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TagId { get; set; }

        public int SortOrder { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Tag1 Tag1 { get; set; }
    }
}
