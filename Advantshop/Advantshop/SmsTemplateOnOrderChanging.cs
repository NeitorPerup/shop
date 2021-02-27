namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.SmsTemplateOnOrderChanging")]
    public partial class SmsTemplateOnOrderChanging
    {
        public int Id { get; set; }

        public int OrderStatusId { get; set; }

        [Required]
        public string SmsText { get; set; }

        public bool Enabled { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }
    }
}
