namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Options")]
    public partial class Options
    {
        [Key]
        public int OptionID { get; set; }

        public int CustomOptionsID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public double PriceBC { get; set; }

        public int PriceType { get; set; }

        public int? SortOrder { get; set; }

        public virtual CustomOptions CustomOptions { get; set; }
    }
}
