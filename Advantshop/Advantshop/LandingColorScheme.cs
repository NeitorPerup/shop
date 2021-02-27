namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingColorScheme")]
    public partial class LandingColorScheme
    {
        public int Id { get; set; }

        public int LpId { get; set; }

        public int LpBlockId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Class { get; set; }

        [Required]
        [StringLength(30)]
        public string BackgroundColor { get; set; }

        [Required]
        [StringLength(30)]
        public string BackgroundColorAlt { get; set; }

        [Required]
        [StringLength(30)]
        public string TitleColor { get; set; }

        [Required]
        [StringLength(30)]
        public string SubTitleColor { get; set; }

        [Required]
        [StringLength(30)]
        public string TextColor { get; set; }

        [Required]
        [StringLength(30)]
        public string TitleBold { get; set; }

        [Required]
        [StringLength(30)]
        public string SubTitleBold { get; set; }

        [Required]
        [StringLength(30)]
        public string TextBold { get; set; }

        [Required]
        [StringLength(30)]
        public string LinkColor { get; set; }

        [Required]
        [StringLength(30)]
        public string LinkColorHover { get; set; }

        [Required]
        [StringLength(30)]
        public string LinkColorActive { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonTextColor { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonBorderColor { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonBorderWidth { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonBorderRadius { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonBackgroundColor { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonBackgroundColorHover { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonBackgroundColorActive { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonSecondaryTextColor { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonSecondaryBorderColor { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonSecondaryBorderWidth { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonSecondaryBorderRadius { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonSecondaryBackgroundColor { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonSecondaryBackgroundColorHover { get; set; }

        [Required]
        [StringLength(30)]
        public string ButtonSecondaryBackgroundColorActive { get; set; }

        [Required]
        [StringLength(30)]
        public string DelimiterColor { get; set; }

        [StringLength(30)]
        public string ButtonTextBold { get; set; }

        [StringLength(30)]
        public string ButtonSecondaryTextBold { get; set; }

        public string TextColorAlt { get; set; }

        public virtual LandingBlock LandingBlock { get; set; }
    }
}
