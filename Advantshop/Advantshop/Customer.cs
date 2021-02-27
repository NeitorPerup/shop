namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Contact = new HashSet<Contact>();
            CustomerFieldValuesMap = new HashSet<CustomerFieldValuesMap>();
            CustomerRoleAction = new HashSet<CustomerRoleAction>();
            FacebookUser = new HashSet<FacebookUser>();
            InstagramUser = new HashSet<InstagramUser>();
            ManagerTask = new HashSet<ManagerTask>();
            OkUser = new HashSet<OkUser>();
            OpenIdLinkCustomer = new HashSet<OpenIdLinkCustomer>();
            SmsNotifications = new HashSet<SmsNotifications>();
            TagMap1 = new HashSet<TagMap1>();
            Task = new HashSet<Task>();
            TelegramUser = new HashSet<TelegramUser>();
            Transaction1 = new HashSet<Transaction1>();
            VkUser = new HashSet<VkUser>();
            Coupon = new HashSet<Coupon>();
            AdminNotification = new HashSet<AdminNotification>();
            CustomerSegment = new HashSet<CustomerSegment>();
            ManagerRole = new HashSet<ManagerRole>();
        }

        public Guid CustomerID { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(70)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; set; }

        public string Phone { get; set; }

        public DateTime RegistrationDateTime { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int? CustomerGroupId { get; set; }

        public int? CustomerRole { get; set; }

        [StringLength(70)]
        public string Patronymic { get; set; }

        public long? BonusCardNumber { get; set; }

        public string AdminComment { get; set; }

        public int? ManagerId { get; set; }

        public int Rating { get; set; }

        public long? StandardPhone { get; set; }

        [StringLength(100)]
        public string Avatar { get; set; }

        public bool Enabled { get; set; }

        public Guid? HeadCustomerId { get; set; }

        public DateTime? BirthDay { get; set; }

        [StringLength(70)]
        public string City { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InnerId { get; set; }

        public int? SortOrder { get; set; }

        [StringLength(250)]
        public string Organization { get; set; }

        public int? ClientStatus { get; set; }

        [StringLength(500)]
        public string RegisteredFrom { get; set; }

        public virtual Card Card { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contact { get; set; }

        public virtual BindedCustomer BindedCustomer { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerFieldValuesMap> CustomerFieldValuesMap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerRoleAction> CustomerRoleAction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacebookUser> FacebookUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstagramUser> InstagramUser { get; set; }

        public virtual Managers Managers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagerTask> ManagerTask { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OkUser> OkUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenIdLinkCustomer> OpenIdLinkCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SmsNotifications> SmsNotifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TagMap1> TagMap1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TelegramUser> TelegramUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction1> Transaction1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VkUser> VkUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coupon> Coupon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminNotification> AdminNotification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSegment> CustomerSegment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagerRole> ManagerRole { get; set; }
    }
}
