namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderSource")]
    public partial class OrderSource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public int SortOrder { get; set; }

        public bool Main { get; set; }

        [Required]
        [StringLength(250)]
        public string Type { get; set; }

        public int? ObjId { get; set; }
    }
}
