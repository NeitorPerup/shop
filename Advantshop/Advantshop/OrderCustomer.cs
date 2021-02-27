namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderCustomer")]
    public partial class OrderCustomer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        public Guid CustomerID { get; set; }

        [Required]
        [StringLength(70)]
        public string CustomerIP { get; set; }

        [Required]
        [StringLength(70)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; set; }

        [StringLength(70)]
        public string Email { get; set; }

        [StringLength(70)]
        public string Phone { get; set; }

        [StringLength(1000)]
        public string Patronymic { get; set; }

        public long? StandardPhone { get; set; }

        [StringLength(70)]
        public string Country { get; set; }

        [StringLength(70)]
        public string Region { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(70)]
        public string Zip { get; set; }

        [StringLength(1000)]
        public string Street { get; set; }

        [StringLength(1000)]
        public string CustomField1 { get; set; }

        [StringLength(1000)]
        public string CustomField2 { get; set; }

        [StringLength(1000)]
        public string CustomField3 { get; set; }

        [StringLength(50)]
        public string House { get; set; }

        [StringLength(50)]
        public string Apartment { get; set; }

        [StringLength(10)]
        public string Structure { get; set; }

        [StringLength(10)]
        public string Entrance { get; set; }

        [StringLength(10)]
        public string Floor { get; set; }

        [StringLength(250)]
        public string Organization { get; set; }

        [StringLength(255)]
        public string District { get; set; }

        public virtual Order1 Order1 { get; set; }
    }
}
