namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partners.LegalEntity")]
    public partial class LegalEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartnerId { get; set; }

        [StringLength(250)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string INN { get; set; }

        [StringLength(50)]
        public string KPP { get; set; }

        [StringLength(500)]
        public string LegalAddress { get; set; }

        [StringLength(500)]
        public string PostAddress { get; set; }

        [StringLength(500)]
        public string ActualAddress { get; set; }

        [StringLength(50)]
        public string SettlementAccount { get; set; }

        [StringLength(250)]
        public string Bank { get; set; }

        [StringLength(50)]
        public string CorrespondentAccount { get; set; }

        [StringLength(50)]
        public string BIK { get; set; }

        [StringLength(70)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string ContactPerson { get; set; }

        [StringLength(250)]
        public string Director { get; set; }

        [StringLength(250)]
        public string Accountant { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        public virtual Partner Partner { get; set; }
    }
}
