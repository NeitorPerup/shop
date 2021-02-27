namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.Landing")]
    public partial class Landing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Landing()
        {
            LandingForm = new HashSet<LandingForm>();
            LandingBlock = new HashSet<LandingBlock>();
            LandingSettings = new HashSet<LandingSettings>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool Enabled { get; set; }

        [Required]
        public string Template { get; set; }

        [Required]
        public string Url { get; set; }

        public DateTime CreatedDate { get; set; }

        public int LandingSiteId { get; set; }

        public bool IsMain { get; set; }

        public int? PageType { get; set; }

        public int? ProductId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingForm> LandingForm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingBlock> LandingBlock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingSettings> LandingSettings { get; set; }
    }
}
