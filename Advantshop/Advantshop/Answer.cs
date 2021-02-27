namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Voice.Answer")]
    public partial class Answer
    {
        public int AnswerID { get; set; }

        public int FKIDTheme { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int CountVoice { get; set; }

        public int Sort { get; set; }

        public bool IsVisible { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime? DateModify { get; set; }

        public virtual VoiceTheme VoiceTheme { get; set; }
    }
}
