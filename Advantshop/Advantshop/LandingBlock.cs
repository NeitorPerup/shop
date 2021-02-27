namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingBlock")]
    public partial class LandingBlock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LandingBlock()
        {
            LandingColorScheme = new HashSet<LandingColorScheme>();
            LandingEmailTemplate = new HashSet<LandingEmailTemplate>();
            LandingSubBlock = new HashSet<LandingSubBlock>();
        }

        public int Id { get; set; }

        public int LandingId { get; set; }

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

        public bool Enabled { get; set; }

        public bool ShowOnAllPages { get; set; }

        public bool NoCache { get; set; }

        public virtual Landing Landing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingColorScheme> LandingColorScheme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingEmailTemplate> LandingEmailTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingSubBlock> LandingSubBlock { get; set; }
    }
}
