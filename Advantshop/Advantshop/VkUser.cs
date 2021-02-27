namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.VkUser")]
    public partial class VkUser
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [StringLength(255)]
        public string BirthDate { get; set; }

        public string Photo100 { get; set; }

        [StringLength(255)]
        public string MobilePhone { get; set; }

        [StringLength(255)]
        public string HomePhone { get; set; }

        [StringLength(10)]
        public string Sex { get; set; }

        [StringLength(255)]
        public string ScreenName { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
