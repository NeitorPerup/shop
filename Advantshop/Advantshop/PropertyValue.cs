namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.PropertyValue")]
    public partial class PropertyValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertyValue()
        {
            RelatedPropertyValues = new HashSet<RelatedPropertyValues>();
            Product = new HashSet<Product>();
        }

        public int PropertyValueID { get; set; }

        public int PropertyID { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public int? SortOrder { get; set; }

        public bool? UseInFilter { get; set; }

        public bool? UseInDetails { get; set; }

        public double RangeValue { get; set; }

        public bool? UseInBrief { get; set; }

        public virtual Property Property { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatedPropertyValues> RelatedPropertyValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
