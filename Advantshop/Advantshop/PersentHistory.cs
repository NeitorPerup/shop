namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bonus.PersentHistory")]
    public partial class PersentHistory
    {
        public int Id { get; set; }

        public Guid CardId { get; set; }

        [Required]
        [StringLength(250)]
        public string GradeName { get; set; }

        [Column(TypeName = "money")]
        public decimal BonusPersent { get; set; }

        public DateTime CreateOn { get; set; }

        [StringLength(250)]
        public string ByAction { get; set; }

        public virtual Card Card { get; set; }
    }
}
