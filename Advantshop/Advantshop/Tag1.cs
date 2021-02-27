namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Tag")]
    public partial class Tag1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tag1()
        {
            TagMap1 = new HashSet<TagMap1>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string Name { get; set; }

        public bool Enabled { get; set; }

        public int? SortOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TagMap1> TagMap1 { get; set; }
    }
}
