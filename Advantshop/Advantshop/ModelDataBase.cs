using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Advantshop
{
    public partial class ModelDataBase : DbContext
    {
        public ModelDataBase()
            : base("name=ModelDataBase")
        {
        }

        public virtual DbSet<AdditionBonus> AdditionBonus { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<CustomRule> CustomRule { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<PersentHistory> PersentHistory { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<RuleLog> RuleLog { get; set; }
        public virtual DbSet<SmsLog> SmsLog { get; set; }
        public virtual DbSet<SmsTemplate> SmsTemplate { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<Affiliate> Affiliate { get; set; }
        public virtual DbSet<AffiliateAdditionalTime> AffiliateAdditionalTime { get; set; }
        public virtual DbSet<AffiliateAnalyticManager> AffiliateAnalyticManager { get; set; }
        public virtual DbSet<AffiliateManager> AffiliateManager { get; set; }
        public virtual DbSet<AffiliateReservationResource> AffiliateReservationResource { get; set; }
        public virtual DbSet<AffiliateSmsTemplate> AffiliateSmsTemplate { get; set; }
        public virtual DbSet<AffiliateTimeOfBooking> AffiliateTimeOfBooking { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<BookingCurrency> BookingCurrency { get; set; }
        public virtual DbSet<BookingItems> BookingItems { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
        public virtual DbSet<ReservationResource> ReservationResource { get; set; }
        public virtual DbSet<ReservationResourceAdditionalTime> ReservationResourceAdditionalTime { get; set; }
        public virtual DbSet<ReservationResourceService> ReservationResourceService { get; set; }
        public virtual DbSet<ReservationResourceTag> ReservationResourceTag { get; set; }
        public virtual DbSet<ReservationResourceTimeOfBooking> ReservationResourceTimeOfBooking { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<CategoriesAutoMapping> CategoriesAutoMapping { get; set; }
        public virtual DbSet<Category1> Category1 { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CustomOptions> CustomOptions { get; set; }
        public virtual DbSet<FileLibrary> FileLibrary { get; set; }
        public virtual DbSet<ImportLog> ImportLog { get; set; }
        public virtual DbSet<Offer> Offer { get; set; }
        public virtual DbSet<OnlineClientInfo> OnlineClientInfo { get; set; }
        public virtual DbSet<OptionPriceTypes> OptionPriceTypes { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product_ProductList> Product_ProductList { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<ProductExt> ProductExt { get; set; }
        public virtual DbSet<ProductFile> ProductFile { get; set; }
        public virtual DbSet<ProductGifts> ProductGifts { get; set; }
        public virtual DbSet<ProductList> ProductList { get; set; }
        public virtual DbSet<ProductVideo> ProductVideo { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyGroup> PropertyGroup { get; set; }
        public virtual DbSet<PropertyValue> PropertyValue { get; set; }
        public virtual DbSet<Ratio> Ratio { get; set; }
        public virtual DbSet<RelatedCategories> RelatedCategories { get; set; }
        public virtual DbSet<RelatedProducts> RelatedProducts { get; set; }
        public virtual DbSet<RelatedProperties> RelatedProperties { get; set; }
        public virtual DbSet<RelatedPropertyValues> RelatedPropertyValues { get; set; }
        public virtual DbSet<ShoppingCart1> ShoppingCart1 { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TagMap> TagMap { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<AdminComment> AdminComment { get; set; }
        public virtual DbSet<AdminNotification> AdminNotification { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<Carousel> Carousel { get; set; }
        public virtual DbSet<ChangeHistory> ChangeHistory { get; set; }
        public virtual DbSet<Landing> Landing { get; set; }
        public virtual DbSet<LandingBlock> LandingBlock { get; set; }
        public virtual DbSet<LandingColorScheme> LandingColorScheme { get; set; }
        public virtual DbSet<LandingDeferredEmail> LandingDeferredEmail { get; set; }
        public virtual DbSet<LandingDomain> LandingDomain { get; set; }
        public virtual DbSet<LandingEmailTemplate> LandingEmailTemplate { get; set; }
        public virtual DbSet<LandingForm> LandingForm { get; set; }
        public virtual DbSet<LandingSettings> LandingSettings { get; set; }
        public virtual DbSet<LandingSite> LandingSite { get; set; }
        public virtual DbSet<LandingSiteSettings> LandingSiteSettings { get; set; }
        public virtual DbSet<LandingSubBlock> LandingSubBlock { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<NewsProduct> NewsProduct { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<ReviewLikes> ReviewLikes { get; set; }
        public virtual DbSet<StaticBlock> StaticBlock { get; set; }
        public virtual DbSet<StaticPage> StaticPage { get; set; }
        public virtual DbSet<TemplatesDocx> TemplatesDocx { get; set; }
        public virtual DbSet<BizProcessRule> BizProcessRule { get; set; }
        public virtual DbSet<DealStatus> DealStatus { get; set; }
        public virtual DbSet<LeadField> LeadField { get; set; }
        public virtual DbSet<LeadFieldValue> LeadFieldValue { get; set; }
        public virtual DbSet<LeadFieldValuesMap> LeadFieldValuesMap { get; set; }
        public virtual DbSet<SalesFunnel> SalesFunnel { get; set; }
        public virtual DbSet<SalesFunnel_Manager> SalesFunnel_Manager { get; set; }
        public virtual DbSet<TriggerAction> TriggerAction { get; set; }
        public virtual DbSet<TriggerCategory> TriggerCategory { get; set; }
        public virtual DbSet<TriggerDeferredData> TriggerDeferredData { get; set; }
        public virtual DbSet<TriggerRule> TriggerRule { get; set; }
        public virtual DbSet<TriggerSendOnceData> TriggerSendOnceData { get; set; }
        public virtual DbSet<AdminInformer> AdminInformer { get; set; }
        public virtual DbSet<Call> Call { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClientCode> ClientCode { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Country_ru> Country_ru { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerCertificate> CustomerCertificate { get; set; }
        public virtual DbSet<CustomerCoupon> CustomerCoupon { get; set; }
        public virtual DbSet<CustomerField> CustomerField { get; set; }
        public virtual DbSet<CustomerFieldValue> CustomerFieldValue { get; set; }
        public virtual DbSet<CustomerFieldValuesMap> CustomerFieldValuesMap { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroup { get; set; }
        public virtual DbSet<CustomerSegment> CustomerSegment { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<FacebookMessage> FacebookMessage { get; set; }
        public virtual DbSet<InstagramMessage> InstagramMessage { get; set; }
        public virtual DbSet<ManagerRole> ManagerRole { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<ManagerTask> ManagerTask { get; set; }
        public virtual DbSet<ManualEmailing> ManualEmailing { get; set; }
        public virtual DbSet<OkMessage> OkMessage { get; set; }
        public virtual DbSet<RecentlyViewsData> RecentlyViewsData { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RoleAction> RoleAction { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<Tag1> Tag1 { get; set; }
        public virtual DbSet<TagMap1> TagMap1 { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskGroup> TaskGroup { get; set; }
        public virtual DbSet<TaskGroupManager> TaskGroupManager { get; set; }
        public virtual DbSet<TaskManager> TaskManager { get; set; }
        public virtual DbSet<TaskObserver> TaskObserver { get; set; }
        public virtual DbSet<TelegramMessage> TelegramMessage { get; set; }
        public virtual DbSet<ViewedTask> ViewedTask { get; set; }
        public virtual DbSet<VkMessage> VkMessage { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ASPStateTempApplications> ASPStateTempApplications { get; set; }
        public virtual DbSet<ASPStateTempSessions> ASPStateTempSessions { get; set; }
        public virtual DbSet<BreakMessage> BreakMessage { get; set; }
        public virtual DbSet<DownloadableContent> DownloadableContent { get; set; }
        public virtual DbSet<MessageLog> MessageLog { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<SaasData> SaasData { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<AppRestartLog> AppRestartLog { get; set; }
        public virtual DbSet<SimalandModification> SimalandModification { get; set; }
        public virtual DbSet<SimalandModifier> SimalandModifier { get; set; }
        public virtual DbSet<SimalandSettings> SimalandSettings { get; set; }
        public virtual DbSet<OkCatalog> OkCatalog { get; set; }
        public virtual DbSet<OkProduct> OkProduct { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<Lead> Lead { get; set; }
        public virtual DbSet<LeadCurrency> LeadCurrency { get; set; }
        public virtual DbSet<LeadEvent> LeadEvent { get; set; }
        public virtual DbSet<LeadItem> LeadItem { get; set; }
        public virtual DbSet<Order1> Order1 { get; set; }
        public virtual DbSet<OrderAdditionalData> OrderAdditionalData { get; set; }
        public virtual DbSet<OrderByRequest> OrderByRequest { get; set; }
        public virtual DbSet<OrderConfirmation> OrderConfirmation { get; set; }
        public virtual DbSet<OrderContact> OrderContact { get; set; }
        public virtual DbSet<OrderCurrency> OrderCurrency { get; set; }
        public virtual DbSet<OrderCustomer> OrderCustomer { get; set; }
        public virtual DbSet<OrderCustomOptions> OrderCustomOptions { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<OrderItemsFromMoysklad> OrderItemsFromMoysklad { get; set; }
        public virtual DbSet<OrderPickPoint> OrderPickPoint { get; set; }
        public virtual DbSet<OrderPriceDiscount> OrderPriceDiscount { get; set; }
        public virtual DbSet<OrderSendMoysklad> OrderSendMoysklad { get; set; }
        public virtual DbSet<OrderSource> OrderSource { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderTax> OrderTax { get; set; }
        public virtual DbSet<OrderTrafficSource> OrderTrafficSource { get; set; }
        public virtual DbSet<PaymentDetails1> PaymentDetails1 { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<PaymentParam> PaymentParam { get; set; }
        public virtual DbSet<ShippingCache> ShippingCache { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethod { get; set; }
        public virtual DbSet<ShippingParam> ShippingParam { get; set; }
        public virtual DbSet<ShippingPayments> ShippingPayments { get; set; }
        public virtual DbSet<ShippingReplaceGeo> ShippingReplaceGeo { get; set; }
        public virtual DbSet<ActReport> ActReport { get; set; }
        public virtual DbSet<BindedCustomer> BindedCustomer { get; set; }
        public virtual DbSet<CategoryRewardPercent> CategoryRewardPercent { get; set; }
        public virtual DbSet<LegalEntity> LegalEntity { get; set; }
        public virtual DbSet<NaturalPerson> NaturalPerson { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PayoutReport> PayoutReport { get; set; }
        public virtual DbSet<Transaction1> Transaction1 { get; set; }
        public virtual DbSet<TransactionCurrency> TransactionCurrency { get; set; }
        public virtual DbSet<MetaInfo> MetaInfo { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<AuthorizeLog> AuthorizeLog { get; set; }
        public virtual DbSet<Error404> Error404 { get; set; }
        public virtual DbSet<ExportFeed> ExportFeed { get; set; }
        public virtual DbSet<ExportFeedSelectedCategories> ExportFeedSelectedCategories { get; set; }
        public virtual DbSet<GiftCertificateTaxes> GiftCertificateTaxes { get; set; }
        public virtual DbSet<InternalSettings> InternalSettings { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Localization> Localization { get; set; }
        public virtual DbSet<MailFormat> MailFormat { get; set; }
        public virtual DbSet<MailFormatType> MailFormatType { get; set; }
        public virtual DbSet<MailTemplate> MailTemplate { get; set; }
        public virtual DbSet<ModuleSettings> ModuleSettings { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCategory> NewsCategory { get; set; }
        public virtual DbSet<ProfitPlan> ProfitPlan { get; set; }
        public virtual DbSet<Ranges> Ranges { get; set; }
        public virtual DbSet<Redirect> Redirect { get; set; }
        public virtual DbSet<Reseller> Reseller { get; set; }
        public virtual DbSet<Settings1> Settings1 { get; set; }
        public virtual DbSet<SettingsSearch> SettingsSearch { get; set; }
        public virtual DbSet<SmsTemplate1> SmsTemplate1 { get; set; }
        public virtual DbSet<SmsTemplateOnOrderChanging> SmsTemplateOnOrderChanging { get; set; }
        public virtual DbSet<TemplateSettings> TemplateSettings { get; set; }
        public virtual DbSet<DpdCashCity> DpdCashCity { get; set; }
        public virtual DbSet<DpdParcelShops> DpdParcelShops { get; set; }
        public virtual DbSet<DpdTerminals> DpdTerminals { get; set; }
        public virtual DbSet<SearchStatistic> SearchStatistic { get; set; }
        public virtual DbSet<VkCategory> VkCategory { get; set; }
        public virtual DbSet<VkOrder_Order> VkOrder_Order { get; set; }
        public virtual DbSet<VkProduct> VkProduct { get; set; }
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<VoiceTheme> VoiceTheme { get; set; }
        public virtual DbSet<AvitoProductProperties> AvitoProductProperties { get; set; }
        public virtual DbSet<DeletedProducts> DeletedProducts { get; set; }
        public virtual DbSet<ProductSuncMoysklad> ProductSuncMoysklad { get; set; }
        public virtual DbSet<SalesChannelExcludedProduct> SalesChannelExcludedProduct { get; set; }
        public virtual DbSet<ClientInfo> ClientInfo { get; set; }
        public virtual DbSet<Country_en> Country_en { get; set; }
        public virtual DbSet<CustomerRoleAction> CustomerRoleAction { get; set; }
        public virtual DbSet<FacebookUser> FacebookUser { get; set; }
        public virtual DbSet<ImapLetter> ImapLetter { get; set; }
        public virtual DbSet<InstagramUser> InstagramUser { get; set; }
        public virtual DbSet<OkUser> OkUser { get; set; }
        public virtual DbSet<OpenIdLinkCustomer> OpenIdLinkCustomer { get; set; }
        public virtual DbSet<SmsNotifications> SmsNotifications { get; set; }
        public virtual DbSet<TelegramUser> TelegramUser { get; set; }
        public virtual DbSet<VkUser> VkUser { get; set; }
        public virtual DbSet<AdminMessages> AdminMessages { get; set; }
        public virtual DbSet<DeferredMail> DeferredMail { get; set; }
        public virtual DbSet<DeletedOrders> DeletedOrders { get; set; }
        public virtual DbSet<OrderHistory> OrderHistory { get; set; }
        public virtual DbSet<OrderPaymentInfo> OrderPaymentInfo { get; set; }
        public virtual DbSet<OrderStatus1C> OrderStatus1C { get; set; }
        public virtual DbSet<StatusHistory> StatusHistory { get; set; }
        public virtual DbSet<ExportFeedSettings> ExportFeedSettings { get; set; }
        public virtual DbSet<GiftCertificatePayments> GiftCertificatePayments { get; set; }
        public virtual DbSet<DDeliveryOrders> DDeliveryOrders { get; set; }
        public virtual DbSet<SdekCities> SdekCities { get; set; }
        public virtual DbSet<VkCategoryImport> VkCategoryImport { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionBonus>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AdditionBonus>()
                .HasMany(e => e.Transaction)
                .WithOptional(e => e.AdditionBonus)
                .HasForeignKey(e => e.AdditionalBonusId);

            modelBuilder.Entity<Card>()
                .Property(e => e.BonusAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Card>()
                .HasMany(e => e.Transaction)
                .WithRequired(e => e.Card)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grade>()
                .Property(e => e.BonusPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Grade>()
                .Property(e => e.PurchaseBarrier)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.Card)
                .WithRequired(e => e.Grade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersentHistory>()
                .Property(e => e.BonusPersent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.PurchaseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.CashAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.MainBonusAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.AdditionBonusAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.NewBonusAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.MainBonusBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.AdditionBonusBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.PurchaseFullAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Purchase>()
                .HasMany(e => e.Transaction)
                .WithOptional(e => e.Purchase)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Affiliate>()
                .HasMany(e => e.Category)
                .WithMany(e => e.Affiliate)
                .Map(m => m.ToTable("AffiliateCategory", "Booking").MapLeftKey("AffiliateId").MapRightKey("CategoryId"));

            modelBuilder.Entity<Affiliate>()
                .HasMany(e => e.Service)
                .WithMany(e => e.Affiliate)
                .Map(m => m.ToTable("AffiliateService", "Booking").MapLeftKey("AffiliateId").MapRightKey("ServiceId"));

            modelBuilder.Entity<Booking>()
                .HasOptional(e => e.BookingCurrency)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Booking>()
                .HasOptional(e => e.PaymentDetails)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BookingCurrency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<ReservationResource>()
                .HasMany(e => e.ShoppingCart)
                .WithOptional(e => e.ReservationResource)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ReservationResource>()
                .HasMany(e => e.ReservationResourceTag)
                .WithMany(e => e.ReservationResource)
                .Map(m => m.ToTable("ReservationResourceTagsMap", "Booking").MapLeftKey("ReservationResourceId").MapRightKey("ReservationResourceTagId"));

            modelBuilder.Entity<Service>()
                .HasMany(e => e.OrderItems)
                .WithOptional(e => e.Service)
                .HasForeignKey(e => e.BookingServiceId);

            modelBuilder.Entity<Category1>()
                .HasMany(e => e.Category11)
                .WithOptional(e => e.Category12)
                .HasForeignKey(e => e.ParentCategory);

            modelBuilder.Entity<Category1>()
                .HasOptional(e => e.CategoryRewardPercent)
                .WithRequired(e => e.Category1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Category1>()
                .HasMany(e => e.Coupon)
                .WithMany(e => e.Category1)
                .Map(m => m.ToTable("CouponCategories", "Catalog").MapLeftKey("CategoryID").MapRightKey("CouponID"));

            modelBuilder.Entity<Category1>()
                .HasMany(e => e.PropertyGroup)
                .WithMany(e => e.Category1)
                .Map(m => m.ToTable("PropertyGroupCategory", "Catalog").MapLeftKey("CategoryId").MapRightKey("PropertyGroupId"));

            modelBuilder.Entity<Category1>()
                .HasMany(e => e.SalesFunnel)
                .WithMany(e => e.Category1)
                .Map(m => m.ToTable("SalesFunnel_LeadAutoCompleteCategory", "CRM").MapLeftKey("CategoryId").MapRightKey("SalesFunnelId"));

            modelBuilder.Entity<Category1>()
                .HasMany(e => e.OkCatalog)
                .WithMany(e => e.Category1)
                .Map(m => m.ToTable("OkCatalog_Category", "Ok").MapLeftKey("CategoryId").MapRightKey("OkCatalogId"));

            modelBuilder.Entity<Category1>()
                .HasMany(e => e.ShippingMethod)
                .WithMany(e => e.Category1)
                .Map(m => m.ToTable("ShippingCategoryExcluded", "Order").MapLeftKey("CategoryId").MapRightKey("MethodId"));

            modelBuilder.Entity<Category1>()
                .HasMany(e => e.VkCategory)
                .WithMany(e => e.Category1)
                .Map(m => m.ToTable("VkCategory_Category", "Vk").MapLeftKey("CategoryId").MapRightKey("VkCategoryId"));

            modelBuilder.Entity<Coupon>()
                .Property(e => e.MinimalOrderPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Coupon>()
                .HasMany(e => e.Customer)
                .WithMany(e => e.Coupon)
                .Map(m => m.ToTable("CouponCustomers", "Catalog").MapLeftKey("CouponID").MapRightKey("CustomerID"));

            modelBuilder.Entity<Currency>()
                .Property(e => e.CurrencyIso3)
                .IsFixedLength();

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.Service)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.ProductGifts)
                .WithRequired(e => e.Offer)
                .HasForeignKey(e => e.GiftOfferId);

            modelBuilder.Entity<OptionPriceTypes>()
                .Property(e => e.StringKey)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.ShippingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.ProductExt)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.ProductSuncMoysklad)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.SimalandModification)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Coupon)
                .WithMany(e => e.Product)
                .Map(m => m.ToTable("CouponProducts", "Catalog").MapLeftKey("ProductID").MapRightKey("CouponID"));

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PropertyValue)
                .WithMany(e => e.Product)
                .Map(m => m.ToTable("ProductPropertyValue", "Catalog").MapLeftKey("ProductID").MapRightKey("PropertyValueID"));

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SalesFunnel)
                .WithMany(e => e.Product)
                .Map(m => m.ToTable("SalesFunnel_LeadAutoCompleteProduct", "CRM").MapLeftKey("ProductId").MapRightKey("SalesFunnelId"));

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ShippingMethod)
                .WithMany(e => e.Product)
                .Map(m => m.ToTable("ShippingProductExcluded", "Order").MapLeftKey("ProductId").MapRightKey("MethodId"));

            modelBuilder.Entity<ProductList>()
                .HasMany(e => e.Product_ProductList)
                .WithRequired(e => e.ProductList)
                .HasForeignKey(e => e.ListId);

            modelBuilder.Entity<Tax>()
                .HasOptional(e => e.GiftCertificateTaxes)
                .WithRequired(e => e.Tax)
                .WillCascadeOnDelete();

            modelBuilder.Entity<AdminNotification>()
                .HasMany(e => e.Customer)
                .WithMany(e => e.AdminNotification)
                .Map(m => m.ToTable("AdminNotifications", "Customers").MapLeftKey("AdminNotificationid").MapRightKey("CustomerId"));

            modelBuilder.Entity<Landing>()
                .HasMany(e => e.LandingForm)
                .WithRequired(e => e.Landing)
                .HasForeignKey(e => e.LpId);

            modelBuilder.Entity<LandingBlock>()
                .HasMany(e => e.LandingColorScheme)
                .WithRequired(e => e.LandingBlock)
                .HasForeignKey(e => e.LpBlockId);

            modelBuilder.Entity<LandingBlock>()
                .HasMany(e => e.LandingEmailTemplate)
                .WithRequired(e => e.LandingBlock)
                .HasForeignKey(e => e.BlockId);

            modelBuilder.Entity<LandingSite>()
                .HasMany(e => e.Product)
                .WithMany(e => e.LandingSite)
                .Map(m => m.ToTable("LandingSite_Product", "CMS").MapLeftKey("LandingSiteId").MapRightKey("ProductId"));

            modelBuilder.Entity<DealStatus>()
                .HasMany(e => e.SalesFunnel)
                .WithMany(e => e.DealStatus)
                .Map(m => m.ToTable("SalesFunnel_DealStatus", "CRM").MapLeftKey("DealStatusId").MapRightKey("SalesFunnelId"));

            modelBuilder.Entity<TriggerCategory>()
                .HasMany(e => e.TriggerRule)
                .WithOptional(e => e.TriggerCategory)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<TriggerRule>()
                .HasMany(e => e.TriggerSendOnceData)
                .WithRequired(e => e.TriggerRule)
                .HasForeignKey(e => e.TriggerId);

            modelBuilder.Entity<City>()
                .HasMany(e => e.PaymentMethod)
                .WithMany(e => e.City)
                .Map(m => m.ToTable("PaymentCity", "Order").MapLeftKey("CityId").MapRightKey("MethodId"));

            modelBuilder.Entity<City>()
                .HasMany(e => e.ShippingMethod)
                .WithMany(e => e.City)
                .Map(m => m.ToTable("ShippingCity", "Order").MapLeftKey("CityId").MapRightKey("MethodId"));

            modelBuilder.Entity<City>()
                .HasMany(e => e.ShippingMethod1)
                .WithMany(e => e.City1)
                .Map(m => m.ToTable("ShippingCityExcluded", "Order").MapLeftKey("CityId").MapRightKey("MethodId"));

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryISO2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryISO3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasOptional(e => e.Country1)
                .WithRequired(e => e.Country2);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.PaymentMethod)
                .WithMany(e => e.Country)
                .Map(m => m.ToTable("PaymentCountry", "Order").MapLeftKey("CountryId").MapRightKey("MethodId"));

            modelBuilder.Entity<Country>()
                .HasMany(e => e.ShippingMethod)
                .WithMany(e => e.Country)
                .Map(m => m.ToTable("ShippingCountry", "Order").MapLeftKey("CountryId").MapRightKey("MethodId"));

            modelBuilder.Entity<Country>()
                .HasMany(e => e.ShippingMethod1)
                .WithMany(e => e.Country1)
                .Map(m => m.ToTable("ShippingCountryExcluded", "Order").MapLeftKey("CountryId").MapRightKey("MethodId"));

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.Card)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Contact)
                .WithOptional(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.BindedCustomer)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.Managers)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.TelegramUser)
                .WithOptional(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerSegment)
                .WithMany(e => e.Customer)
                .Map(m => m.ToTable("CustomerSegment_Customer", "Customers").MapLeftKey("CustomerId").MapRightKey("SegmentId"));

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ManagerRole)
                .WithMany(e => e.Customer)
                .Map(m => m.ToTable("ManagerRolesMap", "Customers").MapLeftKey("CustomerId").MapRightKey("ManagerRoleId"));

            modelBuilder.Entity<ManagerRole>()
                .HasMany(e => e.TaskGroup)
                .WithMany(e => e.ManagerRole)
                .Map(m => m.ToTable("TaskGroupManagerRole", "Customers").MapLeftKey("ManagerRoleId").MapRightKey("TaskGroupId"));

            modelBuilder.Entity<Region>()
                .HasMany(e => e.ShippingMethod)
                .WithMany(e => e.Region)
                .Map(m => m.ToTable("ShippingRegion", "Order").MapLeftKey("RegionId").MapRightKey("MethodId"));

            modelBuilder.Entity<Region>()
                .HasMany(e => e.ShippingMethod1)
                .WithMany(e => e.Region1)
                .Map(m => m.ToTable("ShippingRegionExcluded", "Order").MapLeftKey("RegionId").MapRightKey("MethodId"));

            modelBuilder.Entity<Tag1>()
                .HasMany(e => e.TagMap1)
                .WithRequired(e => e.Tag1)
                .HasForeignKey(e => e.TagId);

            modelBuilder.Entity<TaskGroup>()
                .HasMany(e => e.Task)
                .WithRequired(e => e.TaskGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ASPStateTempApplications>()
                .Property(e => e.AppName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SimalandModifier>()
                .HasMany(e => e.SimalandModification)
                .WithRequired(e => e.SimalandModifier)
                .HasForeignKey(e => e.ModifierId);

            modelBuilder.Entity<Certificate>()
                .HasOptional(e => e.Certificate1)
                .WithRequired(e => e.Certificate2);

            modelBuilder.Entity<Lead>()
                .HasOptional(e => e.LeadCurrency)
                .WithRequired(e => e.Lead)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LeadCurrency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<Order1>()
                .HasMany(e => e.Certificate)
                .WithOptional(e => e.Order1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Order1>()
                .HasMany(e => e.DDeliveryOrders)
                .WithRequired(e => e.Order1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order1>()
                .HasOptional(e => e.OrderCurrency)
                .WithRequired(e => e.Order1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Order1>()
                .HasOptional(e => e.OrderCustomer)
                .WithRequired(e => e.Order1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Order1>()
                .HasOptional(e => e.OrderPickPoint)
                .WithRequired(e => e.Order1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Order1>()
                .HasOptional(e => e.OrderSendMoysklad)
                .WithRequired(e => e.Order1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Order1>()
                .HasOptional(e => e.PaymentDetails1)
                .WithRequired(e => e.Order1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<OrderCurrency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<OrderCustomOptions>()
                .Property(e => e.OptionPriceBC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderItems>()
                .HasMany(e => e.OrderCustomOptions)
                .WithRequired(e => e.OrderItems)
                .HasForeignKey(e => e.OrderedCartID);

            modelBuilder.Entity<OrderItems>()
                .HasOptional(e => e.OrderItems1)
                .WithRequired(e => e.OrderItems2);

            modelBuilder.Entity<OrderStatus>()
                .HasMany(e => e.Order1)
                .WithRequired(e => e.OrderStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentMethod>()
                .HasOptional(e => e.GiftCertificatePayments)
                .WithRequired(e => e.PaymentMethod)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ShippingReplaceGeo>()
                .Property(e => e.InCountryISO2)
                .IsUnicode(false);

            modelBuilder.Entity<Partner>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Partner>()
                .HasOptional(e => e.LegalEntity)
                .WithRequired(e => e.Partner)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Partner>()
                .HasOptional(e => e.NaturalPerson)
                .WithRequired(e => e.Partner)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Partner>()
                .HasMany(e => e.Transaction1)
                .WithRequired(e => e.Partner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction1>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction1>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction1>()
                .HasOptional(e => e.TransactionCurrency)
                .WithRequired(e => e.Transaction1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TransactionCurrency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<ExportFeed>()
                .HasMany(e => e.Product)
                .WithMany(e => e.ExportFeed)
                .Map(m => m.ToTable("ExportFeedExcludedProducts", "Settings").MapLeftKey("ExportFeedId").MapRightKey("ProductId"));

            modelBuilder.Entity<Ranges>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DpdCashCity>()
                .Property(e => e.CountryCode)
                .IsFixedLength();

            modelBuilder.Entity<DpdParcelShops>()
                .Property(e => e.CountryCode)
                .IsFixedLength();

            modelBuilder.Entity<DpdTerminals>()
                .Property(e => e.CountryCode)
                .IsFixedLength();

            modelBuilder.Entity<VoiceTheme>()
                .HasMany(e => e.Answer)
                .WithRequired(e => e.VoiceTheme)
                .HasForeignKey(e => e.FKIDTheme);
        }
    }
}
