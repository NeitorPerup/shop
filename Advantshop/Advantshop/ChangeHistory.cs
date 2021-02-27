namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.ChangeHistory")]
    public partial class ChangeHistory
    {
        public int Id { get; set; }

        public int ObjId { get; set; }

        public int ObjType { get; set; }

        [Required]
        [StringLength(350)]
        public string ParameterName { get; set; }

        [Required]
        public string OldValue { get; set; }

        [Required]
        public string NewValue { get; set; }

        public int ParameterType { get; set; }

        public int? ParameterId { get; set; }

        [Required]
        [StringLength(255)]
        public string ChangedByName { get; set; }

        public Guid? ChangedById { get; set; }

        public DateTime ModificationTime { get; set; }
    }
}
