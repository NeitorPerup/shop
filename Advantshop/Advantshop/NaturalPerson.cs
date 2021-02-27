namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partners.NaturalPerson")]
    public partial class NaturalPerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartnerId { get; set; }

        [StringLength(70)]
        public string FirstName { get; set; }

        [StringLength(70)]
        public string LastName { get; set; }

        [StringLength(70)]
        public string Patronymic { get; set; }

        [StringLength(50)]
        public string PassportSeria { get; set; }

        [StringLength(50)]
        public string PassportNumber { get; set; }

        [StringLength(250)]
        public string PassportWhoGive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PassportWhenGive { get; set; }

        [StringLength(500)]
        public string RegistrationAddress { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public int? PaymentTypeId { get; set; }

        [StringLength(250)]
        public string PaymentAccountNumber { get; set; }

        public virtual Partner Partner { get; set; }
    }
}
