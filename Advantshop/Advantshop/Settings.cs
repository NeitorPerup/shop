namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEO.Settings")]
    public partial class Settings
    {
        [Key]
        public int SettingID { get; set; }

        [Required]
        [StringLength(50)]
        public string ParamName { get; set; }

        [Required]
        public string ParamValue { get; set; }
    }
}
