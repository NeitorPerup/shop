namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipping.SdekCities")]
    public partial class SdekCities
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string CityName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string OblName { get; set; }

        [StringLength(100)]
        public string NalSumLimit { get; set; }
    }
}
