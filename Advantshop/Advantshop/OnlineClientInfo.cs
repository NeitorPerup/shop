namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.OnlineClientInfo")]
    public partial class OnlineClientInfo
    {
        [Key]
        [StringLength(100)]
        public string sessionID { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string UserAgentBrowser { get; set; }

        [Required]
        [StringLength(200)]
        public string LastAccessedPath { get; set; }

        public DateTime Started { get; set; }

        [Required]
        [StringLength(100)]
        public string UserAgentOS { get; set; }

        [Required]
        [StringLength(100)]
        public string CountryByGeoIp { get; set; }
    }
}
