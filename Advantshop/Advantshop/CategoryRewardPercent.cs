namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partners.CategoryRewardPercent")]
    public partial class CategoryRewardPercent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        public double RewardPercent { get; set; }

        public DateTime DateAdded { get; set; }

        public virtual Category1 Category1 { get; set; }
    }
}
