namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            BookingItems = new HashSet<BookingItems>();
            ReservationResourceService = new HashSet<ReservationResourceService>();
            OrderItems = new HashSet<OrderItems>();
            Affiliate = new HashSet<Affiliate>();
        }

        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int CurrencyId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public double Price { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Enabled { get; set; }

        public long? Duration { get; set; }

        [Required]
        [StringLength(100)]
        public string ArtNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingItems> BookingItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationResourceService> ReservationResourceService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }

        public virtual Currency Currency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Affiliate> Affiliate { get; set; }
    }
}
