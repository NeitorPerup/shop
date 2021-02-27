namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.Menu")]
    public partial class Menu
    {
        [Key]
        public int MenuItemID { get; set; }

        public int? MenuItemParentID { get; set; }

        [Required]
        [StringLength(100)]
        public string MenuItemName { get; set; }

        [StringLength(100)]
        public string MenuItemIcon { get; set; }

        [Required]
        public string MenuItemUrlPath { get; set; }

        public int MenuItemUrlType { get; set; }

        public int SortOrder { get; set; }

        public int ShowMode { get; set; }

        public bool Enabled { get; set; }

        public bool Blank { get; set; }

        public bool NoFollow { get; set; }

        public int MenuType { get; set; }
    }
}
