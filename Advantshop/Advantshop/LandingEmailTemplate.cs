namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingEmailTemplate")]
    public partial class LandingEmailTemplate
    {
        public int Id { get; set; }

        public int BlockId { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

        public int SendingTime { get; set; }

        public virtual LandingBlock LandingBlock { get; set; }
    }
}
