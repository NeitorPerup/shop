namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bonus.RuleLog")]
    public partial class RuleLog
    {
        [Key]
        [Column(Order = 0)]
        public Guid CardId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RuleType { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Created { get; set; }

        public virtual Card Card { get; set; }

        public virtual CustomRule CustomRule { get; set; }
    }
}
