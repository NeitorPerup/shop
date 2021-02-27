namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Property")]
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            PropertyValue = new HashSet<PropertyValue>();
            RelatedProperties = new HashSet<RelatedProperties>();
        }

        public int PropertyID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool? UseInFilter { get; set; }

        public int? SortOrder { get; set; }

        public bool? Expanded { get; set; }

        public bool? UseInDetails { get; set; }

        public string Description { get; set; }

        [StringLength(25)]
        public string Unit { get; set; }

        public int Type { get; set; }

        public int? GroupId { get; set; }

        public bool? UseInBrief { get; set; }

        [Required]
        [StringLength(100)]
        public string NameDisplayed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyValue> PropertyValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatedProperties> RelatedProperties { get; set; }
    }
}
