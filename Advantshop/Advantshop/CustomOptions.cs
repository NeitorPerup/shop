namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.CustomOptions")]
    public partial class CustomOptions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomOptions()
        {
            Options = new HashSet<Options>();
        }

        public int CustomOptionsID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public bool IsRequired { get; set; }

        public int InputType { get; set; }

        public int? SortOrder { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Options> Options { get; set; }
    }
}
