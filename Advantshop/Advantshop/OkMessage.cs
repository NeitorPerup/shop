namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.OkMessage")]
    public partial class OkMessage
    {
        public int Id { get; set; }

        [Required]
        public string MessageId { get; set; }

        [Required]
        public string ChatId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string FromUser { get; set; }

        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
