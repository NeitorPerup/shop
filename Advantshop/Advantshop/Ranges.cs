namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.Ranges")]
    public partial class Ranges
    {
        [Key]
        public int RangeID { get; set; }

        public double Bound { get; set; }

        [Column(TypeName = "money")]
        public decimal Value { get; set; }

        public int Type { get; set; }
    }
}
