namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.Affiliate")]
    public partial class Affiliate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Affiliate()
        {
            AffiliateAdditionalTime = new HashSet<AffiliateAdditionalTime>();
            AffiliateAnalyticManager = new HashSet<AffiliateAnalyticManager>();
            AffiliateManager = new HashSet<AffiliateManager>();
            AffiliateReservationResource = new HashSet<AffiliateReservationResource>();
            AffiliateSmsTemplate = new HashSet<AffiliateSmsTemplate>();
            AffiliateTimeOfBooking = new HashSet<AffiliateTimeOfBooking>();
            Booking = new HashSet<Booking>();
            ReservationResourceAdditionalTime = new HashSet<ReservationResourceAdditionalTime>();
            ReservationResourceService = new HashSet<ReservationResourceService>();
            ReservationResourceTimeOfBooking = new HashSet<ReservationResourceTimeOfBooking>();
            ShoppingCart = new HashSet<ShoppingCart>();
            Category = new HashSet<Category>();
            Service = new HashSet<Service>();
        }

        public int Id { get; set; }

        public int? CityId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        public int BookingIntervalMinutes { get; set; }

        public int SortOrder { get; set; }

        public bool Enabled { get; set; }

        public bool AccessForAll { get; set; }

        public bool IsActiveSmsNotification { get; set; }

        public int? ForHowManyMinutesToSendSms { get; set; }

        [StringLength(500)]
        public string SmsTemplateBeforeStartBooiking { get; set; }

        public bool AnalyticsAccessForAll { get; set; }

        public bool AccessToViewBookingForResourceManagers { get; set; }

        public int? CancelUnpaidViaMinutes { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AffiliateAdditionalTime> AffiliateAdditionalTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AffiliateAnalyticManager> AffiliateAnalyticManager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AffiliateManager> AffiliateManager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AffiliateReservationResource> AffiliateReservationResource { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AffiliateSmsTemplate> AffiliateSmsTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AffiliateTimeOfBooking> AffiliateTimeOfBooking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationResourceAdditionalTime> ReservationResourceAdditionalTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationResourceService> ReservationResourceService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationResourceTimeOfBooking> ReservationResourceTimeOfBooking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Service { get; set; }
    }
}
