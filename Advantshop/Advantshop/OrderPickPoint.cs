namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderPickPoint")]
    public partial class OrderPickPoint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string PickPointId { get; set; }

        [Required]
        [StringLength(500)]
        public string PickPointAddress { get; set; }

        public string AdditionalData { get; set; }

        public virtual Order1 Order1 { get; set; }
    }
}
