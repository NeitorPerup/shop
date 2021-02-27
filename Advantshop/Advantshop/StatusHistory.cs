namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.StatusHistory")]
    public partial class StatusHistory
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string PreviousStatus { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string NewStatus { get; set; }

        public Guid? CustomerID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Basis { get; set; }
    }
}
