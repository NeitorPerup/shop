namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Category")]
    public partial class Category1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category1()
        {
            Category11 = new HashSet<Category1>();
            ExportFeedSelectedCategories = new HashSet<ExportFeedSelectedCategories>();
            ProductCategories = new HashSet<ProductCategories>();
            RelatedProperties = new HashSet<RelatedProperties>();
            RelatedPropertyValues = new HashSet<RelatedPropertyValues>();
            VkCategoryImport = new HashSet<VkCategoryImport>();
            Coupon = new HashSet<Coupon>();
            PropertyGroup = new HashSet<PropertyGroup>();
            SalesFunnel = new HashSet<SalesFunnel>();
            OkCatalog = new HashSet<OkCatalog>();
            ShippingMethod = new HashSet<ShippingMethod>();
            VkCategory = new HashSet<VkCategory>();
        }

        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int? ParentCategory { get; set; }

        public string Description { get; set; }

        public int Products_Count { get; set; }

        public int SortOrder { get; set; }

        public bool Enabled { get; set; }

        public int Total_Products_Count { get; set; }

        public bool DisplayChildProducts { get; set; }

        [Required]
        [StringLength(150)]
        public string UrlPath { get; set; }

        public bool HirecalEnabled { get; set; }

        public bool DisplayBrandsInMenu { get; set; }

        public bool DisplaySubCategoriesInMenu { get; set; }

        public int? CatLevel { get; set; }

        public string BriefDescription { get; set; }

        public int Sorting { get; set; }

        public int DisplayStyle { get; set; }

        public bool Hidden { get; set; }

        public bool? IsDemo { get; set; }

        [StringLength(50)]
        public string ExternalId { get; set; }

        public int Available_Products_Count { get; set; }

        public int Current_Products_Count { get; set; }

        public int? AutomapAction { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateAdded { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public bool? ShowOnMainPage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category1> Category11 { get; set; }

        public virtual Category1 Category12 { get; set; }

        public virtual CategoryRewardPercent CategoryRewardPercent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportFeedSelectedCategories> ExportFeedSelectedCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCategories> ProductCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatedProperties> RelatedProperties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelatedPropertyValues> RelatedPropertyValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VkCategoryImport> VkCategoryImport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coupon> Coupon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyGroup> PropertyGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesFunnel> SalesFunnel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OkCatalog> OkCatalog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingMethod> ShippingMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VkCategory> VkCategory { get; set; }
    }
}
