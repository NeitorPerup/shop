namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderHistory")]
    public partial class OrderHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Parameter { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParameterType { get; set; }

        [StringLength(50)]
        public string ParameterValue { get; set; }

        public string ParameterDescription { get; set; }

        [Key]
        [Column(Order = 3)]
        public string OldValue { get; set; }

        [Key]
        [Column(Order = 4)]
        public string NewValue { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string ManagerName { get; set; }

        public Guid? ManagerId { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime ModificationTime { get; set; }
    }
}
