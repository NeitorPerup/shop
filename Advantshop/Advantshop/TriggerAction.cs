namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRM.TriggerAction")]
    public partial class TriggerAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TriggerAction()
        {
            TriggerDeferredData = new HashSet<TriggerDeferredData>();
        }

        public int Id { get; set; }

        public int TriggerRuleId { get; set; }

        public int ActionType { get; set; }

        public string TimeDelay { get; set; }

        public string EmailSubject { get; set; }

        public string EmailBody { get; set; }

        public string SmsText { get; set; }

        public Guid EmailingId { get; set; }

        public string EditFieldValue { get; set; }

        public int? EditFieldType { get; set; }

        public int? ObjId { get; set; }

        public int? SmartCallsCampaignID { get; set; }

        public int? DealStatusId { get; set; }

        public int? RequestMethod { get; set; }

        public string RequestUrl { get; set; }

        public string RequestParams { get; set; }

        public string RequestHeaderParams { get; set; }

        public int? SortOrder { get; set; }

        public int? RequestParamsType { get; set; }

        public string RequestParamsJson { get; set; }

        public virtual TriggerRule TriggerRule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TriggerDeferredData> TriggerDeferredData { get; set; }
    }
}
