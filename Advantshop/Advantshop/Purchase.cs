namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bonus.Purchase")]
    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }

        public Guid CardId { get; set; }

        public DateTime CreateOn { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreateOnCut { get; set; }

        [Column(TypeName = "money")]
        public decimal PurchaseAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal CashAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal MainBonusAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal AdditionBonusAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal NewBonusAmount { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        [Column(TypeName = "money")]
        public decimal MainBonusBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal AdditionBonusBalance { get; set; }

        public int Status { get; set; }

        [Column(TypeName = "money")]
        public decimal PurchaseFullAmount { get; set; }

        public int? OrderId { get; set; }

        public virtual Card Card { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
