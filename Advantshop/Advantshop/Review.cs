namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.Review")]
    public partial class Review
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Review()
        {
            ReviewLikes = new HashSet<ReviewLikes>();
            Task = new HashSet<Task>();
        }

        public int ReviewId { get; set; }

        public int ParentId { get; set; }

        public int EntityId { get; set; }

        public int Type { get; set; }

        public Guid CustomerId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime AddDate { get; set; }

        public bool Checked { get; set; }

        [Required]
        [StringLength(50)]
        public string IP { get; set; }

        public int LikesCount { get; set; }

        public int DislikesCount { get; set; }

        public int RatioByLikes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReviewLikes> ReviewLikes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task { get; set; }
    }
}
