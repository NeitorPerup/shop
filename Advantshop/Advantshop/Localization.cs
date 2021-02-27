namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.Localization")]
    public partial class Localization
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ResourceKey { get; set; }

        [Required]
        public string ResourceValue { get; set; }
    }
}
