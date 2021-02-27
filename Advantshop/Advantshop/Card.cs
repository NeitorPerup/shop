namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bonus.Card")]
    public partial class Card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Card()
        {
            AdditionBonus = new HashSet<AdditionBonus>();
            PersentHistory = new HashSet<PersentHistory>();
            Purchase = new HashSet<Purchase>();
            RuleLog = new HashSet<RuleLog>();
            Transaction = new HashSet<Transaction>();
        }

        public Guid CardId { get; set; }

        public long CardNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal BonusAmount { get; set; }

        public DateTime CreateOn { get; set; }

        public long Blocked { get; set; }

        public int GradeId { get; set; }

        public DateTime? DateLastWipeBonus { get; set; }

        public bool ManualGrade { get; set; }

        public DateTime? DateLastNotifyBonusWipe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionBonus> AdditionBonus { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Grade Grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersentHistory> PersentHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleLog> RuleLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
