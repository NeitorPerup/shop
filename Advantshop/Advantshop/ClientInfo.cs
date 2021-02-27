namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.ClientInfo")]
    public partial class ClientInfo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string sessionID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string UserAgentBrowser { get; set; }

        [Key]
        [Column(Order = 3)]
        public string LastAccessedPath { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Started { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string UserAgentOS { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string CountryByGeoIp { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime Ended { get; set; }
    }
}
