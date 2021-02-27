namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Internal.AppRestartLog")]
    public partial class AppRestartLog
    {
        public int ID { get; set; }

        public DateTime RestartDate { get; set; }

        [Required]
        public string ServerName { get; set; }
    }
}
