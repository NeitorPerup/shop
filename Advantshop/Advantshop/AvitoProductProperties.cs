namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.AvitoProductProperties")]
    public partial class AvitoProductProperties
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string PropertyName { get; set; }

        [Key]
        [Column(Order = 2)]
        public string PropertyValue { get; set; }

        public virtual Product Product { get; set; }
    }
}
