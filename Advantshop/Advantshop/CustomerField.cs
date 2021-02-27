namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.CustomerField")]
    public partial class CustomerField
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerField()
        {
            CustomerFieldValue = new HashSet<CustomerFieldValue>();
            CustomerFieldValuesMap = new HashSet<CustomerFieldValuesMap>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int FieldType { get; set; }

        public int SortOrder { get; set; }

        public bool Required { get; set; }

        public bool Enabled { get; set; }

        public bool ShowInRegistration { get; set; }

        public bool ShowInCheckout { get; set; }

        public bool DisableCustomerEditing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerFieldValue> CustomerFieldValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerFieldValuesMap> CustomerFieldValuesMap { get; set; }
    }
}
