namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.OrderByRequest")]
    public partial class OrderByRequest
    {
        public int OrderByRequestId { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string ArtNo { get; set; }

        public double Quantity { get; set; }

        [Required]
        [StringLength(140)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Comment { get; set; }

        public bool IsComplete { get; set; }

        public DateTime RequestDate { get; set; }

        [StringLength(64)]
        public string Code { get; set; }

        public DateTime? CodeCreateDate { get; set; }

        public int? OfferID { get; set; }

        public string LetterComment { get; set; }

        public string Options { get; set; }
    }
}
