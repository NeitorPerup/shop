namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.GiftCertificateTaxes")]
    public partial class GiftCertificateTaxes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxID { get; set; }

        public virtual Tax Tax { get; set; }
    }
}
