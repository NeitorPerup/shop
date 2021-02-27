namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.TelegramMessage")]
    public partial class TelegramMessage
    {
        public int Id { get; set; }

        public int MessageId { get; set; }

        public int FromId { get; set; }

        public int? ToId { get; set; }

        public DateTime Date { get; set; }

        public string Text { get; set; }

        public long? ChatId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }
    }
}
