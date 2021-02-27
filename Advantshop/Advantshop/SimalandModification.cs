namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Module.SimalandModification")]
    public partial class SimalandModification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public int ModificationId { get; set; }

        public int ModifierId { get; set; }

        [Required]
        [StringLength(255)]
        public string Value { get; set; }

        public int SortOrder { get; set; }

        public virtual Product Product { get; set; }

        public virtual SimalandModifier SimalandModifier { get; set; }
    }
}
