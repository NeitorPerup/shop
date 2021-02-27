namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.ManualEmailing")]
    public partial class ManualEmailing
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Subject { get; set; }

        public int TotalCount { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
