namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRM.TriggerDeferredData")]
    public partial class TriggerDeferredData
    {
        public int Id { get; set; }

        public int EntityId { get; set; }

        public int TriggerActionId { get; set; }

        public int TriggerObjectType { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual TriggerAction TriggerAction { get; set; }
    }
}
