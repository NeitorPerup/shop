namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingSiteSettings")]
    public partial class LandingSiteSettings
    {
        public int Id { get; set; }

        public int LandingSiteId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        public virtual LandingSite LandingSite { get; set; }
    }
}
