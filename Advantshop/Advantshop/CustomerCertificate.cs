namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.CustomerCertificate")]
    public partial class CustomerCertificate
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CertificateID { get; set; }

        public virtual Certificate Certificate { get; set; }
    }
}
