namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.Redirect")]
    public partial class Redirect
    {
        public int ID { get; set; }

        [StringLength(450)]
        public string RedirectFrom { get; set; }

        [StringLength(450)]
        public string RedirectTo { get; set; }

        [StringLength(50)]
        public string ProductArtNo { get; set; }

        public DateTime Created { get; set; }

        public DateTime Edited { get; set; }
    }
}
