namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bonus.SmsTemplate")]
    public partial class SmsTemplate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SmsTypeId { get; set; }

        [StringLength(500)]
        public string SmsBody { get; set; }
    }
}
