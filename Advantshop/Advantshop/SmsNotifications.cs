namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.SmsNotifications")]
    public partial class SmsNotifications
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerID { get; set; }

        [StringLength(5)]
        public string Code { get; set; }

        [StringLength(10)]
        public string Number { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Subscribed4SMSNews { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Subscribed4SMSOrde { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsBlack { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
