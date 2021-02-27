namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.ImportLog")]
    public partial class ImportLog
    {
        public int ID { get; set; }

        public int mtype { get; set; }

        [Required]
        public string message { get; set; }
    }
}
