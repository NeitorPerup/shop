namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.MailFormat")]
    public partial class MailFormat
    {
        public int MailFormatID { get; set; }

        [Required]
        [StringLength(70)]
        public string FormatName { get; set; }

        [Required]
        public string FormatText { get; set; }

        public int? SortOrder { get; set; }

        public bool Enable { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime ModifyDate { get; set; }

        public string FormatSubject { get; set; }

        public int? MailFormatTypeId { get; set; }

        public virtual MailFormatType MailFormatType { get; set; }
    }
}
