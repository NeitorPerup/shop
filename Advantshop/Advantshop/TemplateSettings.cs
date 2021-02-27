namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.TemplateSettings")]
    public partial class TemplateSettings
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Template { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
