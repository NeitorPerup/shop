namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.FileLibrary")]
    public partial class FileLibrary
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [StringLength(150)]
        public string ItemName { get; set; }

        public int? ItemParentID { get; set; }

        [StringLength(100)]
        public string ItemIcon { get; set; }

        public int ItemType { get; set; }

        [StringLength(100)]
        public string filePath { get; set; }

        public bool Enabled { get; set; }

        public int SortOrder { get; set; }
    }
}
