namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Voice.VoiceTheme")]
    public partial class VoiceTheme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VoiceTheme()
        {
            Answer = new HashSet<Answer>();
        }

        public int VoiceThemeID { get; set; }

        public int PSYID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsHaveNullVoice { get; set; }

        public bool IsDefault { get; set; }

        public bool IsClose { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime? DateModify { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answer { get; set; }
    }
}
