namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bonus.Transaction")]
    public partial class Transaction
    {
        public int Id { get; set; }

        public Guid CardId { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [StringLength(500)]
        public string Basis { get; set; }

        public DateTime CreateOn { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreateOnCut { get; set; }

        public short OperationType { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public int? PurchaseId { get; set; }

        public int? AdditionalBonusId { get; set; }

        public virtual AdditionBonus AdditionBonus { get; set; }

        public virtual Card Card { get; set; }

        public virtual Purchase Purchase { get; set; }
    }
}
