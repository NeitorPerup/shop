namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Statistic.SearchStatistic")]
    public partial class SearchStatistic
    {
        public int ID { get; set; }

        [Required]
        public string Request { get; set; }

        public int ResultCount { get; set; }

        public DateTime Date { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string SearchTerm { get; set; }

        [StringLength(250)]
        public string CustomerID { get; set; }
    }
}
