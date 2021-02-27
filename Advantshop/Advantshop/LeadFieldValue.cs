namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRM.LeadFieldValue")]
    public partial class LeadFieldValue
    {
        public int Id { get; set; }

        public int LeadFieldId { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public int SortOrder { get; set; }

        public virtual LeadField LeadField { get; set; }
    }
}
