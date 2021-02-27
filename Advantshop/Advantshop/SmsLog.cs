namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bonus.SmsLog")]
    public partial class SmsLog
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public string State { get; set; }

        public long Phone { get; set; }

        public DateTime Created { get; set; }
    }
}
