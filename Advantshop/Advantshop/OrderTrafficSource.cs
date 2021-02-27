namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderTrafficSource")]
    public partial class OrderTrafficSource
    {
        public int Id { get; set; }

        public int ObjId { get; set; }

        public int ObjType { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime? CreateOn { get; set; }

        public string Referrer { get; set; }

        public string Url { get; set; }

        public string utm_source { get; set; }

        public string utm_medium { get; set; }

        public string utm_campaign { get; set; }

        public string utm_content { get; set; }

        public string utm_term { get; set; }

        [StringLength(50)]
        public string GoogleClientId { get; set; }
    }
}
