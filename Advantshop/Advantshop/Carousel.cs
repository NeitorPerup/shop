namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.Carousel")]
    public partial class Carousel
    {
        public int CarouselID { get; set; }

        [Required]
        public string URL { get; set; }

        public int SortOrder { get; set; }

        public bool Enabled { get; set; }

        public bool DisplayInOneColumn { get; set; }

        public bool DisplayInTwoColumns { get; set; }

        public bool DisplayInMobile { get; set; }

        public bool Blank { get; set; }
    }
}
