namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vk.VkProduct")]
    public partial class VkProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public long MainPhotoId { get; set; }

        [Required]
        public string PhotoIds { get; set; }

        public long AlbumId { get; set; }

        public string PhotosMapIds { get; set; }

        public virtual Product Product { get; set; }
    }
}
