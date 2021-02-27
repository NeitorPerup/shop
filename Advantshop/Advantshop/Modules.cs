namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Modules
    {
        [Key]
        public int ModuleID { get; set; }

        [Required]
        [StringLength(150)]
        public string ModuleStringID { get; set; }

        public bool IsInstall { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateModified { get; set; }

        [StringLength(20)]
        public string Version { get; set; }

        public bool Active { get; set; }

        public bool NeedUpdate { get; set; }
    }
}
