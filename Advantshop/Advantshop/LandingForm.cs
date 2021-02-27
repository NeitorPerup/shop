namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMS.LandingForm")]
    public partial class LandingForm
    {
        public int Id { get; set; }

        public int LpId { get; set; }

        public int? BlockId { get; set; }

        public string Title { get; set; }

        public string ButtonText { get; set; }

        public string FieldsJson { get; set; }

        public int PostAction { get; set; }

        public string PostMessageText { get; set; }

        [StringLength(300)]
        public string PostMessageRedirectUrl { get; set; }

        [StringLength(50)]
        public string YaMetrikaEventName { get; set; }

        [StringLength(50)]
        public string GaEventCategory { get; set; }

        [StringLength(50)]
        public string GaEventAction { get; set; }

        public bool? ShowAgreement { get; set; }

        public string AgreementText { get; set; }

        public int? PayProductOfferId { get; set; }

        public int? SalesFunnelId { get; set; }

        public bool? IsHidden { get; set; }

        public string SubTitle { get; set; }

        public string EmailText { get; set; }

        public string EmailSubject { get; set; }

        public string PostMessageRedirectLpId { get; set; }

        public string OfferId { get; set; }

        public int? InputTextPosition { get; set; }

        public bool? DontSendLeadId { get; set; }

        public string OfferPrice { get; set; }

        public string OfferItemsJson { get; set; }

        public int? ActionUpsellLpId { get; set; }

        public int? PostMessageRedirectDelay { get; set; }

        public bool? PostMessageRedirectShowMessage { get; set; }

        public bool? AgreementDefaultChecked { get; set; }

        public virtual Landing Landing { get; set; }
    }
}
