namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Call")]
    public partial class Call
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string CallId { get; set; }

        [Required]
        [StringLength(250)]
        public string Type { get; set; }

        [Required]
        [StringLength(250)]
        public string SrcNum { get; set; }

        [Required]
        [StringLength(250)]
        public string DstNum { get; set; }

        [Required]
        [StringLength(250)]
        public string Extension { get; set; }

        public DateTime CallDate { get; set; }

        public DateTime? CallAnswerDate { get; set; }

        public int Duration { get; set; }

        [StringLength(250)]
        public string RecordLink { get; set; }

        public bool CalledBack { get; set; }

        [Required]
        [StringLength(250)]
        public string HangupStatus { get; set; }

        [Required]
        [StringLength(250)]
        public string OperatorType { get; set; }

        public int? ManagerId { get; set; }

        [Required]
        [StringLength(250)]
        public string Phone { get; set; }

        public bool IsComplete { get; set; }
    }
}
