namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partners.ActReport")]
    public partial class ActReport
    {
        public int Id { get; set; }

        public int PartnerId { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        public DateTime PeriodFrom { get; set; }

        public DateTime PeriodTo { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual Partner Partner { get; set; }
    }
}
