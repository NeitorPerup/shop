namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.ReviewLikes")]
    public partial class ReviewLikes
    {
        public int Id { get; set; }

        public int ReviewId { get; set; }

        public bool IsLike { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime AddDate { get; set; }

        public virtual Review Review { get; set; }
    }
}
