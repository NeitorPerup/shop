namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaasData")]
    public partial class SaasData
    {
        [Key]
        [StringLength(255)]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
