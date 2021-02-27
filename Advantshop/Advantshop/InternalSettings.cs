namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.InternalSettings")]
    public partial class InternalSettings
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string settingKey { get; set; }

        [Required]
        [StringLength(50)]
        public string settingValue { get; set; }
    }
}
