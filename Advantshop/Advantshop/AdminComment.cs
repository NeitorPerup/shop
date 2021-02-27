namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.AdminComment")]
    public partial class AdminComment
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int ObjId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public Guid? CustomerId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public bool Deleted { get; set; }
    }
}
