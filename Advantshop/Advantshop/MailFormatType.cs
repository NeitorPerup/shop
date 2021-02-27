namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.MailFormatType")]
    public partial class MailFormatType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MailFormatType()
        {
            MailFormat = new HashSet<MailFormat>();
        }

        public int MailFormatTypeID { get; set; }

        [Required]
        [StringLength(70)]
        public string TypeName { get; set; }

        public int? SortOrder { get; set; }

        public string Comment { get; set; }

        [Required]
        [StringLength(70)]
        public string MailType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailFormat> MailFormat { get; set; }
    }
}
