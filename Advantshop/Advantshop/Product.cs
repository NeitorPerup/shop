namespace Advantshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalog.Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            CustomOptions = new HashSet<CustomOptions>();
            Offer = new HashSet<Offer>();
            AvitoProductProperties = new HashSet<AvitoProductProperties>();
            LeadItem = new HashSet<LeadItem>();
            NewsProduct = new HashSet<NewsProduct>();
            OrderItems = new HashSet<OrderItems>();
            Product_ProductList = new HashSet<Product_ProductList>();
            ProductCategories = new HashSet<ProductCategories>();
            ProductFile = new HashSet<ProductFile>();
            SalesChannelExcludedProduct = new HashSet<SalesChannelExcludedProduct>();
            ProductVideo = new HashSet<ProductVideo>();
            Ratio1 = new HashSet<Ratio>();
            RecentlyViewsData = new HashSet<RecentlyViewsData>();
            VkProduct = new HashSet<VkProduct>();
            Coupon = new HashSet<Coupon>();
            PropertyValue = new HashSet<PropertyValue>();
            LandingSite = new HashSet<LandingSite>();
            SalesFunnel = new HashSet<SalesFunnel>();
            ShippingMethod = new HashSet<ShippingMethod>();
            ExportFeed = new HashSet<ExportFeed>();
        }

        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ArtNo { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public double Ratio { get; set; }

        public double? Discount { get; set; }

        public double? Weight { get; set; }

        public string BriefDescription { get; set; }

        public string Description { get; set; }

        public bool Enabled { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateModified { get; set; }

        public bool? Recomended { get; set; }

        public bool? New { get; set; }

        public bool? Bestseller { get; set; }

        public bool? OnSale { get; set; }

        public int? BrandID { get; set; }

        public bool? AllowPreOrder { get; set; }

        public int? SortBestseller { get; set; }

        public int? SortNew { get; set; }

        public int? SortDiscount { get; set; }

        [StringLength(150)]
        public string UrlPath { get; set; }

        public bool? CategoryEnabled { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippingPrice { get; set; }

        public double? MinAmount { get; set; }

        public double? MaxAmount { get; set; }

        public double Multiplicity { get; set; }

        public bool HasMultiOffer { get; set; }

        [StringLength(50)]
        public string SalesNote { get; set; }

        [StringLength(500)]
        public string GoogleProductCategory { get; set; }

        [StringLength(50)]
        public string Gtin { get; set; }

        public bool Adult { get; set; }

        public double? Length { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }

        public int CurrencyID { get; set; }

        public bool ActiveView360 { get; set; }

        [StringLength(500)]
        public string YandexMarketCategory { get; set; }

        public bool? ManufacturerWarranty { get; set; }

        [StringLength(50)]
        public string CustomViewName { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(500)]
        public string YandexTypePrefix { get; set; }

        [StringLength(500)]
        public string YandexModel { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        public double? Bid { get; set; }

        public double? Fee { get; set; }

        public double? DiscountAmount { get; set; }

        public bool? AccrueBonuses { get; set; }

        public int? TaxId { get; set; }

        public bool? IsDemo { get; set; }

        [StringLength(10)]
        public string YandexSizeUnit { get; set; }

        [StringLength(255)]
        public string YandexName { get; set; }

        public bool? Cpa { get; set; }

        [StringLength(5)]
        public string YandexDeliveryDays { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public int PaymentSubjectType { get; set; }

        public int PaymentMethodType { get; set; }

        public bool Hidden { get; set; }

        public double? ManualRatio { get; set; }

        public int? SortPopular { get; set; }

        public bool? YandexProductDiscounted { get; set; }

        [StringLength(10)]
        public string YandexProductDiscountCondition { get; set; }

        [StringLength(3000)]
        public string YandexProductDiscountReason { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Currency Currency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomOptions> CustomOptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvitoProductProperties> AvitoProductProperties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadItem> LeadItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsProduct> NewsProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItems> OrderItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_ProductList> Product_ProductList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCategories> ProductCategories { get; set; }

        public virtual ProductExt ProductExt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductFile> ProductFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesChannelExcludedProduct> SalesChannelExcludedProduct { get; set; }

        public virtual ProductSuncMoysklad ProductSuncMoysklad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVideo> ProductVideo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ratio> Ratio1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecentlyViewsData> RecentlyViewsData { get; set; }

        public virtual SimalandModification SimalandModification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VkProduct> VkProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coupon> Coupon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyValue> PropertyValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingSite> LandingSite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesFunnel> SalesFunnel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingMethod> ShippingMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportFeed> ExportFeed { get; set; }
    }
}
