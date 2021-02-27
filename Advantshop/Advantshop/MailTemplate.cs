namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.MailTemplate")]
    public partial class MailTemplate
    {
        [Key]
        public int TemplateId { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        [StringLength(250)]
        public string Subject { get; set; }

        public int SortOrder { get; set; }

        public bool Active { get; set; }
    }
}
