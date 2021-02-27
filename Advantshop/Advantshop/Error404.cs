namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.Error404")]
    public partial class Error404
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Url { get; set; }

        [StringLength(4000)]
        public string UrlReferer { get; set; }

        [StringLength(100)]
        public string IpAddress { get; set; }

        public string UserAgent { get; set; }

        public DateTime? DateAdded { get; set; }
    }
}
