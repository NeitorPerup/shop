namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Managers")]
    public partial class Managers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManagerId { get; set; }

        [Key]
        public Guid CustomerId { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        public bool Active { get; set; }

        public string Sign { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Departments Departments { get; set; }
    }
}
