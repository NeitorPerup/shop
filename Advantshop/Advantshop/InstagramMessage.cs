namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.InstagramMessage")]
    public partial class InstagramMessage
    {
        public int Id { get; set; }

        [Required]
        public string ThreadId { get; set; }

        [Required]
        public string MediaPk { get; set; }

        [Required]
        public string InstagramId { get; set; }

        [Required]
        public string FromUserPk { get; set; }

        [Required]
        public string ToUserPk { get; set; }

        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? ItemType { get; set; }

        public string Title { get; set; }
    }
}
