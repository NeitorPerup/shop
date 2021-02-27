namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order.LeadItem")]
    public partial class LeadItem
    {
        public int LeadItemId { get; set; }

        public int LeadId { get; set; }

        public int? ProductId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ArtNo { get; set; }

        public double Price { get; set; }

        public double Amount { get; set; }

        public double Weight { get; set; }

        [StringLength(300)]
        public string Color { get; set; }

        [StringLength(300)]
        public string Size { get; set; }

        public int? PhotoId { get; set; }

        public double? Length { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }

        public string CustomOptionsJson { get; set; }

        public virtual Photo Photo { get; set; }

        public virtual Product Product { get; set; }

        public virtual Lead Lead { get; set; }
    }
}
