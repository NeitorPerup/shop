namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.TemplatesDocx")]
    public partial class TemplatesDocx
    {
        public int Id { get; set; }

        public byte Type { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int SortOrder { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        public int FileSize { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public bool? DebugMode { get; set; }
    }
}
