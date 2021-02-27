namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partners.Transaction")]
    public partial class Transaction1
    {
        public int Id { get; set; }

        public int PartnerId { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [StringLength(500)]
        public string Basis { get; set; }

        public Guid? CustomerId { get; set; }

        public int? OrderId { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsRewardPayout { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RewardPeriodTo { get; set; }

        public string DetailsJson { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Order1 Order1 { get; set; }

        public virtual Partner Partner { get; set; }

        public virtual TransactionCurrency TransactionCurrency { get; set; }
    }
}
