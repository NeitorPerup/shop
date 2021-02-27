namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partners.Partner")]
    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            ActReport = new HashSet<ActReport>();
            BindedCustomer = new HashSet<BindedCustomer>();
            Transaction1 = new HashSet<Transaction1>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(70)]
        public string Phone { get; set; }

        [Required]
        [StringLength(70)]
        public string City { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public int SendMessages { get; set; }

        public string AdminComment { get; set; }

        public bool Enabled { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public int Type { get; set; }

        public int? CouponId { get; set; }

        public double RewardPercent { get; set; }

        public bool ContractConcluded { get; set; }

        [StringLength(250)]
        public string ContractNumber { get; set; }

        public DateTime? ContractDate { get; set; }

        [StringLength(250)]
        public string ContractScan { get; set; }

        public virtual Coupon Coupon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActReport> ActReport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BindedCustomer> BindedCustomer { get; set; }

        public virtual LegalEntity LegalEntity { get; set; }

        public virtual NaturalPerson NaturalPerson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction1> Transaction1 { get; set; }
    }
}
