namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.FacebookUser")]
    public partial class FacebookUser
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CustomerId { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Gender { get; set; }

        public string PsyId { get; set; }

        public string PhotoPicByPsyId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
