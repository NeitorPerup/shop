namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingSubBlock")]
    public partial class LandingSubBlock
    {
        public int Id { get; set; }

        public int LandingBlockId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ContentHtml { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }

        [Required]
        public string Settings { get; set; }

        public int SortOrder { get; set; }

        public virtual LandingBlock LandingBlock { get; set; }
    }
}
