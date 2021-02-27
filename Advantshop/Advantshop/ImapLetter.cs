namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.ImapLetter")]
    public partial class ImapLetter
    {
        [Key]
        [Column(Order = 0)]
        public string Id { get; set; }

        public string Folder { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Subject { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Date { get; set; }

        public string From { get; set; }

        public string FromEmail { get; set; }

        public string To { get; set; }

        public string ToEmail { get; set; }
    }
}
