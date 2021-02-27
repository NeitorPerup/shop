namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.ReservationResource")]
    public partial class ReservationResource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReservationResource()
        {
            AffiliateReservationResource = new HashSet<AffiliateReservationResource>();
            Booking = new HashSet<Booking>();
            ReservationResourceAdditionalTime = new HashSet<ReservationResourceAdditionalTime>();
            ReservationResourceService = new HashSet<ReservationResourceService>();
            ReservationResourceTimeOfBooking = new HashSet<ReservationResourceTimeOfBooking>();
            ShoppingCart = new HashSet<ShoppingCart>();
            ReservationResourceTag = new HashSet<ReservationResourceTag>();
        }

        public int Id { get; set; }

        public int? ManagerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public bool Enabled { get; set; }

        public int SortOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AffiliateReservationResource> AffiliateReservationResource { get; set; }

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
        public virtual ICollection<ReservationResourceTag> ReservationResourceTag { get; set; }
    }
}
