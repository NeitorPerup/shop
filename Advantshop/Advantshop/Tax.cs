namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Tax")]
    public partial class Tax
    {
        public int TaxID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool Enabled { get; set; }

        public bool ShowInPrice { get; set; }

        public double Rate { get; set; }

        public int TaxType { get; set; }

        public virtual GiftCertificateTaxes GiftCertificateTaxes { get; set; }
    }
}
