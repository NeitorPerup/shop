namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRM.TriggerRule")]
    public partial class TriggerRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TriggerRule()
        {
            TriggerAction = new HashSet<TriggerAction>();
            TriggerSendOnceData = new HashSet<TriggerSendOnceData>();
        }

        public int Id { get; set; }

        public int EventType { get; set; }

        public int ObjectType { get; set; }

        public int? EventObjId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Filter { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public bool Enabled { get; set; }

        public bool WorksOnlyOnce { get; set; }

        public int? EventObjValue { get; set; }

        public int ProcessType { get; set; }

        public string TriggerParams { get; set; }

        public int? PreferredHour { get; set; }

        public int? CategoryId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TriggerAction> TriggerAction { get; set; }

        public virtual TriggerCategory TriggerCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TriggerSendOnceData> TriggerSendOnceData { get; set; }
    }
}
