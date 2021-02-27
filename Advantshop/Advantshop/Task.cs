namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customers.Task")]
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            LeadEvent = new HashSet<LeadEvent>();
            TaskManager = new HashSet<TaskManager>();
            TaskObserver = new HashSet<TaskObserver>();
            ViewedTask = new HashSet<ViewedTask>();
        }

        public int Id { get; set; }

        public int TaskGroupId { get; set; }

        public int? AppointedManagerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int Status { get; set; }

        public int Priority { get; set; }

        public DateTime? DueDate { get; set; }

        public int? LeadId { get; set; }

        public int? OrderId { get; set; }

        public Guid? CustomerId { get; set; }

        [StringLength(255)]
        public string ResultShort { get; set; }

        public string ResultFull { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public bool Accepted { get; set; }

        public DateTime DateAppointed { get; set; }

        public bool IsAutomatic { get; set; }

        public bool IsDeferred { get; set; }

        public int? ReviewId { get; set; }

        public int? SortOrder { get; set; }

        public int? BindedTaskId { get; set; }

        public int? BindedObjectStatus { get; set; }

        public int Reminder { get; set; }

        public bool Reminded { get; set; }

        public virtual Review Review { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadEvent> LeadEvent { get; set; }

        public virtual Lead Lead { get; set; }

        public virtual Order1 Order1 { get; set; }

        public virtual TaskGroup TaskGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskManager> TaskManager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskObserver> TaskObserver { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewedTask> ViewedTask { get; set; }
    }
}
