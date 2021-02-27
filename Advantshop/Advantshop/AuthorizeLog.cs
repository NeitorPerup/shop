namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Settings.AuthorizeLog")]
    public partial class AuthorizeLog
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Login { get; set; }

        public bool isAdmin { get; set; }

        [Required]
        [StringLength(50)]
        public string UserIP { get; set; }

        public bool isSuccess { get; set; }

        public DateTime AddDate { get; set; }
    }
}
