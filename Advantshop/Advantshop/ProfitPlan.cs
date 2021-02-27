namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.ProfitPlan")]
    public partial class ProfitPlan
    {
        [Key]
        public int PlanID { get; set; }

        public int SalesPlan { get; set; }

        [Column("ProfitPlan")]
        public double ProfitPlan1 { get; set; }

        public DateTime Date { get; set; }
    }
}
