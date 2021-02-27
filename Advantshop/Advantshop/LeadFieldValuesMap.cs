namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRM.LeadFieldValuesMap")]
    public partial class LeadFieldValuesMap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeadId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeadFieldId { get; set; }

        [Required]
        public string Value { get; set; }

        public virtual LeadField LeadField { get; set; }

        public virtual Lead Lead { get; set; }
    }
}
