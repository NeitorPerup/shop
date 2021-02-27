namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.ExportFeedSettings")]
    public partial class ExportFeedSettings
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExportFeedId { get; set; }

        public string Value { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string FileExtention { get; set; }

        public double? PriceMargin { get; set; }

        public bool? ExportNotAmountProducts { get; set; }

        public bool? ExportNotActiveProducts { get; set; }

        public string AdditionalUrlTags { get; set; }

        public bool? Active { get; set; }

        [StringLength(50)]
        public string IntervalType { get; set; }

        public int? Interval { get; set; }

        public DateTime? JobStartTime { get; set; }

        public string AdvancedSettings { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool ExportAllProducts { get; set; }

        public virtual ExportFeed ExportFeed { get; set; }
    }
}
