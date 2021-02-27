namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.ModuleSettings")]
    public partial class ModuleSettings
    {
        [Key]
        public int SettingID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        [StringLength(150)]
        public string ModuleName { get; set; }
    }
}
