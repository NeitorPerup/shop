namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.PropertyGroup")]
    public partial class PropertyGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertyGroup()
        {
            Category1 = new HashSet<Category1>();
        }

        public int PropertyGroupId { get; set; }

        [Required]
        [StringLength(255)]
        public string GroupName { get; set; }

        public int GroupSortOrder { get; set; }

        [Required]
        [StringLength(255)]
        public string GroupNameDisplayed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category1> Category1 { get; set; }
    }
}
