namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Photo")]
    public partial class Photo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photo()
        {
            LeadItem = new HashSet<LeadItem>();
            OrderItems = new HashSet<OrderItems>();
        }

        public int PhotoId { get; set; }

        public int ObjId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(255)]
        public string PhotoName { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string Description { get; set; }

        public int? PhotoSortOrder { get; set; }

        public bool Main { get; set; }

        [StringLength(255)]
        public string OriginName { get; set; }

        public int? ColorID { get; set; }

        [StringLength(255)]
        public string PhotoNameSize1 { get; set; }

        [StringLength(255)]
        public string PhotoNameSize2 { get; set; }

        public virtual Color Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadItem> LeadItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
