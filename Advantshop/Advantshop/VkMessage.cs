namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.VkMessage")]
    public partial class VkMessage
    {
        public int Id { get; set; }

        public long MessageId { get; set; }

        public long UserId { get; set; }

        public DateTime Date { get; set; }

        public string Body { get; set; }

        public long? ChatId { get; set; }

        public long? FromId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public long? PostId { get; set; }
    }
}
