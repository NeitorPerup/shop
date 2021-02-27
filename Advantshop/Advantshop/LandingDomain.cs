namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingDomain")]
    public partial class LandingDomain
    {
        public int Id { get; set; }

        public int LandingSiteId { get; set; }

        [Required]
        public string DomainUrl { get; set; }

        public bool IsMain { get; set; }

        public virtual LandingSite LandingSite { get; set; }
    }
}
