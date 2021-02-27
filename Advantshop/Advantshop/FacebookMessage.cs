namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.FacebookMessage")]
    public partial class FacebookMessage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string MessageId { get; set; }

        public string FromId { get; set; }

        public string ToId { get; set; }

        public string Message { get; set; }

        public DateTime? CreatedTime { get; set; }

        public int Type { get; set; }

        public string PostId { get; set; }

        public string ConversationId { get; set; }
    }
}
