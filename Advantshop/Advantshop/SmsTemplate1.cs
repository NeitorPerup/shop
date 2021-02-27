namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.SmsTemplate")]
    public partial class SmsTemplate1
    {
        [Key]
        public int TemplateId { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }

        public int SortOrder { get; set; }

        public bool Active { get; set; }
    }
}
