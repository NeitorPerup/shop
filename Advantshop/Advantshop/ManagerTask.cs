namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.ManagerTask")]
    public partial class ManagerTask
    {
        [Key]
        public int TaskId { get; set; }

        public int? AssignedManagerId { get; set; }

        public int? AppointedManagerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int Status { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int? OrderId { get; set; }

        public Guid? CustomerId { get; set; }

        public int? LeadId { get; set; }

        [StringLength(255)]
        public string ResultShort { get; set; }

        public string ResultFull { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Lead Lead { get; set; }

        public virtual Order1 Order1 { get; set; }
    }
}
