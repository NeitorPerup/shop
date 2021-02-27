namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.StaticPage")]
    public partial class StaticPage
    {
        public int StaticPageID { get; set; }

        [Required]
        [StringLength(255)]
        public string PageName { get; set; }

        [Required]
        public string PageText { get; set; }

        public int? SortOrder { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime ModifyDate { get; set; }

        public bool? IndexAtSiteMap { get; set; }

        public int? ParentID { get; set; }

        [StringLength(50)]
        public string Comment { get; set; }

        public bool Enabled { get; set; }

        [StringLength(150)]
        public string UrlPath { get; set; }
    }
}
