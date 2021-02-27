namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRM.LeadField")]
    public partial class LeadField
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeadField()
        {
            LeadFieldValue = new HashSet<LeadFieldValue>();
            LeadFieldValuesMap = new HashSet<LeadFieldValuesMap>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int FieldType { get; set; }

        public int SortOrder { get; set; }

        public bool Required { get; set; }

        public bool Enabled { get; set; }

        public int SalesFunnelId { get; set; }

        public virtual SalesFunnel SalesFunnel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadFieldValue> LeadFieldValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadFieldValuesMap> LeadFieldValuesMap { get; set; }
    }
}
