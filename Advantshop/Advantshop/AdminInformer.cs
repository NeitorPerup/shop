namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.AdminInformer")]
    public partial class AdminInformer
    {
        public int Id { get; set; }

        public int Type { get; set; }

        public int ObjId { get; set; }

        public Guid? CustomerId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Link { get; set; }

        public int Count { get; set; }

        public bool Seen { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid? PrivateCustomerId { get; set; }

        public int? EntityId { get; set; }
    }
}
