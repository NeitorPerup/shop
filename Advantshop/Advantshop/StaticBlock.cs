namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.StaticBlock")]
    public partial class StaticBlock
    {
        public int StaticBlockID { get; set; }

        [Required]
        [StringLength(50)]
        public string Key { get; set; }

        [StringLength(255)]
        public string InnerName { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime Added { get; set; }

        public DateTime Modified { get; set; }

        public bool? Enabled { get; set; }
    }
}
