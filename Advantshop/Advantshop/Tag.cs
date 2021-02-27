namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Tag")]
    public partial class Tag
    {
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string Name { get; set; }

        public bool Enabled { get; set; }

        public string BriefDescription { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(450)]
        public string UrlPath { get; set; }

        public int? SortOrder { get; set; }

        public bool? VisibilityForUsers { get; set; }
    }
}
