namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Contact")]
    public partial class Contact
    {
        public Guid ContactID { get; set; }

        public Guid? CustomerID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(70)]
        public string Country { get; set; }

        [StringLength(70)]
        public string City { get; set; }

        [StringLength(70)]
        public string Zone { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(70)]
        public string Zip { get; set; }

        public int? CountryID { get; set; }

        public int? RegionID { get; set; }

        [StringLength(255)]
        public string Street { get; set; }

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

        [StringLength(70)]
        public string District { get; set; }

        public virtual Country Country1 { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Region Region { get; set; }
    }
}
