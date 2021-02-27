namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.RoleAction")]
    public partial class RoleAction
    {
        public int RoleActionID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Key { get; set; }

        public bool Enabled { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public int SortOrder { get; set; }
    }
}
