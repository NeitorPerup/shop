namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.SettingsSearch")]
    public partial class SettingsSearch
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        [StringLength(250)]
        public string Link { get; set; }

        [StringLength(1000)]
        public string KeyWords { get; set; }

        public int SortOrder { get; set; }
    }
}
