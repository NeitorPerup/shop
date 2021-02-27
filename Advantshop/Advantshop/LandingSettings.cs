namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingSettings")]
    public partial class LandingSettings
    {
        public int Id { get; set; }

        public int LandingId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        public virtual Landing Landing { get; set; }
    }
}
