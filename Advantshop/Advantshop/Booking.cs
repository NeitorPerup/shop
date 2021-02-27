namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking.Booking")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            BookingItems = new HashSet<BookingItems>();
        }

        public int Id { get; set; }

        public int AffiliateId { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public byte Status { get; set; }

        public double Sum { get; set; }

        public DateTime DateAdded { get; set; }

        public Guid? CustomerId { get; set; }

        [StringLength(70)]
        public string FirstName { get; set; }

        [StringLength(70)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public string Phone { get; set; }

        [StringLength(70)]
        public string Patronymic { get; set; }

        public long? StandardPhone { get; set; }

        public int? ReservationResourceId { get; set; }

        public int? ManagerId { get; set; }

        public int OrderSourceId { get; set; }

        public bool IsSendedSmsBeforeStart { get; set; }

        public double? BookingDiscount { get; set; }

        public double? BookingDiscountValue { get; set; }

        public double? DiscountCost { get; set; }

        public DateTime? PaymentDate { get; set; }

        public double? PaymentCost { get; set; }

        public int? PaymentMethodID { get; set; }

        [StringLength(255)]
        public string ArchivedPaymentName { get; set; }

        public int? OrderId { get; set; }

        [StringLength(255)]
        public string AdminComment { get; set; }

        public virtual Affiliate Affiliate { get; set; }

        public virtual Order1 Order1 { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual ReservationResource ReservationResource { get; set; }

        public virtual BookingCurrency BookingCurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingItems> BookingItems { get; set; }

        public virtual PaymentDetails PaymentDetails { get; set; }
    }
}
