namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.InstagramUser")]
    public partial class InstagramUser
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Pk { get; set; }

        [Key]
        [Column(Order = 2)]
        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string ProfilePicture { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
