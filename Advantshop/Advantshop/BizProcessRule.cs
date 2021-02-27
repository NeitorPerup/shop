namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRM.BizProcessRule")]
    public partial class BizProcessRule
    {
        public int Id { get; set; }

        public int EventType { get; set; }

        public int ObjectType { get; set; }

        public int? EventObjId { get; set; }

        public int Priority { get; set; }

        [Required]
        [StringLength(255)]
        public string TaskName { get; set; }

        [Required]
        public string TaskDescription { get; set; }

        [StringLength(255)]
        public string TaskDueDateInterval { get; set; }

        [StringLength(255)]
        public string TaskCreateInterval { get; set; }

        public string ManagerFilter { get; set; }

        public string Filter { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int TaskPriority { get; set; }

        public int? TaskGroupId { get; set; }

        public virtual TaskGroup TaskGroup { get; set; }
    }
}
