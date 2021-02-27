namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DownloadableContent")]
    public partial class DownloadableContent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string StringId { get; set; }

        public bool IsInstall { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateModified { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(20)]
        public string Version { get; set; }

        [Required]
        [StringLength(50)]
        public string DcType { get; set; }
    }
}
