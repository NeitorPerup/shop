namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.Certificate")]
    public partial class Certificate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Certificate()
        {
            CustomerCertificate = new HashSet<CustomerCertificate>();
        }

        public int CertificateID { get; set; }

        [Required]
        [StringLength(50)]
        public string CertificateCode { get; set; }

        public int? OrderID { get; set; }

        public string FromName { get; set; }

        [Required]
        public string ToName { get; set; }

        public double Sum { get; set; }

        public string Message { get; set; }

        public bool Used { get; set; }

        public bool Enable { get; set; }

        [Required]
        [StringLength(70)]
        public string ToEmail { get; set; }

        public DateTime CreationDate { get; set; }

        [StringLength(50)]
        public string ApplyOrderNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerCertificate> CustomerCertificate { get; set; }

        public virtual Certificate Certificate1 { get; set; }

        public virtual Certificate Certificate2 { get; set; }

        public virtual Order1 Order1 { get; set; }
    }
}
