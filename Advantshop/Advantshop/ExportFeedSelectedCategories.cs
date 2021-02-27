namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.ExportFeedSelectedCategories")]
    public partial class ExportFeedSelectedCategories
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExportFeedId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }

        public int? status { get; set; }

        public bool Opened { get; set; }

        public virtual Category1 Category1 { get; set; }

        public virtual ExportFeed ExportFeed { get; set; }
    }
}
