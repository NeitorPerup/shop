namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEO.MetaInfo")]
    public partial class MetaInfo
    {
        [Key]
        public int MetaID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public int? ObjId { get; set; }

        [StringLength(40)]
        public string type { get; set; }

        public string H1 { get; set; }
    }
}
