namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.LeadEvent")]
    public partial class LeadEvent
    {
        public int Id { get; set; }

        public int LeadId { get; set; }

        public int Type { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        public int? TaskId { get; set; }

        public Guid? CreatedById { get; set; }

        public virtual Task Task { get; set; }

        public virtual Lead Lead { get; set; }
    }
}
