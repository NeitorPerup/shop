namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.News")]
    public partial class News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News()
        {
            NewsProduct = new HashSet<NewsProduct>();
        }

        public int NewsID { get; set; }

        public int NewsCategoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string TextToPublication { get; set; }

        public string TextToEmail { get; set; }

        [Required]
        public string TextAnnotation { get; set; }

        public bool ShowOnMainPage { get; set; }

        public DateTime AddingDate { get; set; }

        [StringLength(150)]
        public string UrlPath { get; set; }

        public bool Enabled { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsProduct> NewsProduct { get; set; }

        public virtual NewsCategory NewsCategory { get; set; }
    }
}
