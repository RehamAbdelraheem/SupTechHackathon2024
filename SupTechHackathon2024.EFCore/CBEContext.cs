using Microsoft.EntityFrameworkCore;
using SupTechHackathon2024.EFCore.Models;

namespace SupTechHackathon2024.EFCore
{
    public partial class CBEContext : DbContext
    {
        public CBEContext()
        {
        }

        public CBEContext(DbContextOptions<CBEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddressType> AddressTypes { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<BankBranch> BankBranches { get; set; } = null!;
        public virtual DbSet<Call> Calls { get; set; } = null!;
        public virtual DbSet<CbeCustomer> CbeCustomers { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; } = null!;
        public virtual DbSet<CustomerCreditBureauReportingYearlyHistory> CustomerCreditBureauReportingYearlyHistories { get; set; } = null!;
        public virtual DbSet<CustomerRiskRateYearlyHistory> CustomerRiskRateYearlyHistories { get; set; } = null!;
        public virtual DbSet<CustomerType> CustomerTypes { get; set; } = null!;
        public virtual DbSet<EducationLevel> EducationLevels { get; set; } = null!;
        public virtual DbSet<EmploymentStatus> EmploymentStatuses { get; set; } = null!;
        public virtual DbSet<FinancialService> FinancialServices { get; set; } = null!;
        public virtual DbSet<MisSellingCategory> MisSellingCategories { get; set; } = null!;
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; } = null!;
        public virtual DbSet<OfficialIdDocumentType> OfficialIdDocumentTypes { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<RetailAnnualIncome> RetailAnnualIncomes { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<Sme> Smes { get; set; } = null!;
        public virtual DbSet<SmeYearlyFinancialStatement> SmeYearlyFinancialStatements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Arabic_100_CI_AI");

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("AddressType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<BankBranch>(entity =>
            {
                entity.ToTable("BankBranch");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankBranches)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankBranch_BankId");
            });

            modelBuilder.Entity<Call>(entity =>
            {
                entity.ToTable("Call");

                entity.HasIndex(e => e.BankId, "idx_Call_BankId");

                entity.HasIndex(e => e.BankBranchId, "idx_Call_BranchId");

                entity.HasIndex(e => e.FinancialServiceId, "idx_Call_FinancialServiceId");

                entity.HasIndex(e => e.MisSellingCategoryId, "idx_Call_MisSellingCategoryId");

                entity.HasIndex(e => e.IsAiAnalysisFailed, "idx_Call_IsAIAnalysisFailed");

                entity.HasIndex(e => e.IsMisSellingDetected, "idx_Call_IsMisSellingDetected");
                
                entity.Property(e => e.Id)
                .HasDefaultValueSql("NEWSEQUENTIALID()");

                entity.Property(e => e.CbeCustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CbeCustomerId");

                entity.Property(e => e.IsAiAnalysisFailed).HasColumnName("IsAiAnalysisFailed");

                entity.Property(e => e.Transcript).HasColumnType("ntext");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Call_BankId");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.BankBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Call_BankBranchId");

                entity.HasOne(d => d.CbeCustomer)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.CbeCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Call_CbeCustomerId");

                entity.HasOne(d => d.FinancialService)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.FinancialServiceId)
                    .HasConstraintName("FK_Call_FinancialServiceId");

                entity.HasOne(d => d.MisSellingCategory)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.MisSellingCategoryId)
                    .HasConstraintName("FK_Call_MisSellingCategoryId");
            });

            modelBuilder.Entity<CbeCustomer>(entity =>
            {
                entity.ToTable("CbeCustomer");

                entity.HasIndex(e => e.CustomerTypeId, "idx_CbeCustomer_CustomerTypeId");

                entity.HasIndex(e => e.LatestCreditBureauReportingDate, "idx_CbeCustomer_LatestCreditBureauReportingDate");

                entity.HasIndex(e => e.LatestCreditBureauScore, "idx_CbeCustomer_LatestCreditBureauScore");

                entity.HasIndex(e => e.PersonId, "idx_CbeCustomer_PersonId");

                entity.HasIndex(e => e.SmeId, "idx_CbeCustomer_SmeId");

                entity.Property(e => e.Id)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LatestCreditBureauReportingDate).HasColumnType("date");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.CbeCustomers)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CbeCustomer_CustomerTypeId");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CbeCustomers)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_CbeCustomer_PersonId");

                entity.HasOne(d => d.Sme)
                    .WithMany(p => p.CbeCustomers)
                    .HasForeignKey(d => d.SmeId)
                    .HasConstraintName("FK_CbeCustomer_SmeId");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.ToTable("CustomerAddress");

                entity.HasIndex(e => e.CbeCustomerId, "idx_CustomerAddress_CbeCustomerId");

                entity.HasIndex(e => e.TypeId, "idx_CustomerAddress_TypeId");

                entity.Property(e => e.CbeCustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CbeCustomerId");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Governorate).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OtherDetails).HasMaxLength(500);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CbeCustomer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CbeCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAddress_CbeCustomerId");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAddress_TypeId");
            });

            modelBuilder.Entity<CustomerCreditBureauReportingYearlyHistory>(entity =>
            {
                entity.HasKey(e => new { e.CbeCustomerId, e.Year })
                    .HasName("PK_CustomerCreditBureauReportingYearlyHistory");

                entity.ToTable("CustomerCreditBureauReportingYearlyHistory");

                entity.HasIndex(e => e.CbeCustomerId, "idx_CustomerCreditBureauReportingYearlyHistory_CbeCustomerId");

                entity.HasIndex(e => e.Score, "idx_CustomerCreditBureauReportingYearlyHistory_Score");

                entity.Property(e => e.CbeCustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CbeCustomerId");

                entity.HasOne(d => d.CbeCustomer)
                    .WithMany(p => p.CustomerCreditBureauReportingYearlyHistories)
                    .HasForeignKey(d => d.CbeCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerCreditBureauReportingYearlyHistory_CbeCustomerId");
            });

            modelBuilder.Entity<CustomerRiskRateYearlyHistory>(entity =>
            {
                entity.HasKey(e => new { e.CbeCustomerId, e.BankId, e.Year })
                    .HasName("PK_CustomerRiskRateYearlyHistory");

                entity.ToTable("CustomerRiskRateYearlyHistory");

                entity.HasIndex(e => e.CbeCustomerId, "idx_CustomerRiskRateYearlyHistory_CbeCustomerId");

                entity.Property(e => e.CbeCustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CbeCustomerId");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.CustomerRiskRateYearlyHistories)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerRiskRateYearlyHistory_BankId");

                entity.HasOne(d => d.CbeCustomer)
                    .WithMany(p => p.CustomerRiskRateYearlyHistories)
                    .HasForeignKey(d => d.CbeCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerRiskRateYearlyHistory_CbeCustomerId");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.ToTable("CustomerType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<EducationLevel>(entity =>
            {
                entity.ToTable("EducationLevel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<EmploymentStatus>(entity =>
            {
                entity.ToTable("EmploymentStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<FinancialService>(entity =>
            {
                entity.ToTable("FinancialService");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<MisSellingCategory>(entity =>
            {
                entity.ToTable("MisSellingCategory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("MaritalStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<OfficialIdDocumentType>(entity =>
            {
                entity.ToTable("OfficialIdDocumentType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameAr).HasMaxLength(200);

                entity.Property(e => e.NameEn).HasMaxLength(200);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.HasIndex(e => new { e.IdDocumentNumber, e.OfficialIdDocumentTypeId }, "UQ_Person")
                    .IsUnique();

                entity.HasIndex(e => e.EducationLevelId, "idx_Person_EducationLevelId");

                entity.HasIndex(e => e.EmploymentStatusId, "idx_Person_EmploymentStatusId");

                entity.HasIndex(e => e.Gender, "idx_Person_Gender");

                entity.HasIndex(e => e.IdDocumentNumber, "idx_Person_IdDocumentNumber");

                entity.HasIndex(e => e.MaritalStatusId, "idx_Person_MaritalStatusId");

                entity.HasIndex(e => e.OfficialIdDocumentTypeId, "idx_Person_OfficialIdDocumentTypeId");

                entity.Property(e => e.AlternativePhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FullName).HasMaxLength(800);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDocumentNumber).HasMaxLength(100);

                entity.Property(e => e.Occupation).HasMaxLength(500);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK_Person_EducationLevelId");

                entity.HasOne(d => d.EmploymentStatus)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.EmploymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_EmploymentStatusId");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_MaritalStatusId");

                entity.HasOne(d => d.OfficialIdDocumentType)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.OfficialIdDocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_OfficialIdDocumentTypeId");
            });

            modelBuilder.Entity<RetailAnnualIncome>(entity =>
            {
                entity.HasKey(e => new { e.CbeCustomerId, e.BankId, e.Year, e.CurrencyId })
                    .HasName("PK_RetailAnnualIncome");

                entity.ToTable("RetailAnnualIncome");

                entity.HasIndex(e => e.BankId, "idx_RetailAnnualIncome_BankId");

                entity.HasIndex(e => e.CbeCustomerId, "idx_RetailAnnualIncome_CbeCustomerId");

                entity.HasIndex(e => e.CurrencyId, "idx_RetailAnnualIncome_CurrencyId");

                entity.Property(e => e.CbeCustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CbeCustomerId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.RetailAnnualIncomes)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetailAnnualIncome_BankId");

                entity.HasOne(d => d.CbeCustomer)
                    .WithMany(p => p.RetailAnnualIncomes)
                    .HasForeignKey(d => d.CbeCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetailAnnualIncome_CbeCustomerId");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.RetailAnnualIncomes)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetailAnnualIncome_CurrencyId");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("Setting");
            });

            modelBuilder.Entity<Sme>(entity =>
            {
                entity.ToTable("Sme");

                entity.HasIndex(e => e.BusinessRegisterIdNumber, "idx_Sme_BusinessRegisterIdNumber");

                entity.HasIndex(e => e.LegalRepresentativePersonId, "idx_Sme_LegalRepresentativePersonId");

                entity.HasIndex(e => e.TaxIdNumber, "idx_Sme_TaxIdNumber");

                entity.Property(e => e.BusinessRegisterIdNumber).HasMaxLength(100);

                entity.Property(e => e.IndustrySector).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.TaxIdNumber).HasMaxLength(100);

                entity.HasOne(d => d.LegalRepresentativePerson)
                    .WithMany(p => p.Smes)
                    .HasForeignKey(d => d.LegalRepresentativePersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sme_LegalRepresentativePersonId");
            });

            modelBuilder.Entity<SmeYearlyFinancialStatement>(entity =>
            {
                entity.HasKey(e => new { e.CbeCustomerId, e.BankId, e.ReportingDate })
                    .HasName("PK_SmeYearlyFinancialStatement");

                entity.ToTable("SmeYearlyFinancialStatement");

                entity.HasIndex(e => e.BankId, "idx_SmeYearlyFinancialStatement_BankId");

                entity.HasIndex(e => e.CbeCustomerId, "idx_SmeYearlyFinancialStatement_CbeCustomerId");

                entity.HasIndex(e => e.ReportingCurrencyId, "idx_SmeYearlyFinancialStatement_ReportingCurrencyId");

                entity.Property(e => e.CbeCustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CbeCustomerId");

                entity.Property(e => e.ReportingDate).HasColumnType("date");

                entity.Property(e => e.Profit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAssets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalEquity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalLiabilities).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.SmeYearlyFinancialStatements)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SmeYearlyFinancialStatement_BankId");

                entity.HasOne(d => d.CbeCustomer)
                    .WithMany(p => p.SmeYearlyFinancialStatements)
                    .HasForeignKey(d => d.CbeCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SmeYearlyFinancialStatement_CbeCustomerId");

                entity.HasOne(d => d.ReportingCurrency)
                    .WithMany(p => p.SmeYearlyFinancialStatements)
                    .HasForeignKey(d => d.ReportingCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SmeYearlyFinancialStatement_ReportingCurrencyId");
            });

            modelBuilder.Entity<AddressType>().HasData(
                new AddressType { Id = 1, NameAr = "عنوان دائم", NameEn = "Permanent Address" },
                new AddressType { Id = 2, NameAr = "عنوان مؤقت", NameEn = "Temporary Address" },
                new AddressType { Id = 3, NameAr = "عنوان حالي", NameEn = "Current Address" });

            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, NameAr = "الجنيه المصري", NameEn = "Egyptian Pound" },
                new Currency { Id = 2, NameAr = "الدولار الأمريكي", NameEn = "US Dollar" },
                new Currency { Id = 3, NameAr = "اليورو", NameEn = "Euro" },
                new Currency { Id = 4, NameAr = "الين الياباني", NameEn = "Japanese Yen" },
                new Currency { Id = 5, NameAr = "الجنيه الإسترليني", NameEn = "British Pound" },
                new Currency { Id = 6, NameAr = "الريال السعودي", NameEn = "Saudi Riyal" },
                new Currency { Id = 7, NameAr = "الدرهم الإماراتي", NameEn = "UAE Dirham" },
                new Currency { Id = 8, NameAr = "الدينار الكويتي", NameEn = "Kuwaiti Dinar" },
                new Currency { Id = 9, NameAr = "الروبية الهندية", NameEn = "Indian Rupee" },
                new Currency { Id = 10, NameAr = "اليوان الصيني", NameEn = "Chinese Yuan" }
            );

            modelBuilder.Entity<CustomerType>().HasData(
                new CustomerType { Id = 1, NameAr = "أفراد", NameEn = "Retail" },
                new CustomerType { Id = 2, NameAr = "شركات صغيرة ومتوسطة", NameEn = "SMEs" });

            modelBuilder.Entity<EducationLevel>().HasData(
                new EducationLevel { Id = 1, NameAr = "بدون مؤهل (غير متعلم وحتى الإعدادية)", NameEn = "Illiterate to Preparatory School" },
                new EducationLevel { Id = 2, NameAr = "مؤهل متوسط", NameEn = "High School" },
                new EducationLevel { Id = 3, NameAr = "مؤهل عالي", NameEn = "University or Postgraduate Degree" });

            modelBuilder.Entity<EmploymentStatus>().HasData(
                new EmploymentStatus { Id = 1, NameAr = "لا يعمل", NameEn = "Unemployed" },
                new EmploymentStatus { Id = 2, NameAr = "عمل بدخل ثابت", NameEn = "Fixed Income Job" },
                new EmploymentStatus { Id = 3, NameAr = "عمل حر", NameEn = "Self-Employed" }
            );

            modelBuilder.Entity<MaritalStatus>().HasData(
                new MaritalStatus { Id = 1, NameAr = "أعزب", NameEn = "Single" },
                new MaritalStatus { Id = 2, NameAr = "متزوج ولا يعول", NameEn = "Married without Dependents" },
                new MaritalStatus { Id = 3, NameAr = "متزوج ويعول", NameEn = "Married with Dependents" }
            );

            modelBuilder.Entity<OfficialIdDocumentType>().HasData(
                new OfficialIdDocumentType { Id = 1, NameAr = "بطاقة رقم قومي", NameEn = "National Id Card" },
                new OfficialIdDocumentType { Id = 2, NameAr = "جواز سفر", NameEn = "Passport" },
                new OfficialIdDocumentType { Id = 3, NameAr = "سجل تجاري", NameEn = "Business Registeration Document" },
                new OfficialIdDocumentType { Id = 4, NameAr = "بطاقة ضريبية", NameEn = "Tax Identification Document" });

            modelBuilder.Entity<FinancialService>().HasData(
                new FinancialService { Id = 1, NameAr = "بطاقة ائتمان", NameEn = "Credit Card" },
                new FinancialService { Id = 2, NameAr = "قرض شخصي", NameEn = "Personal Loan" },
                new FinancialService { Id = 3, NameAr = "حساب توفير", NameEn = "Savings Account" },
                new FinancialService { Id = 4, NameAr = "خدمات التأمين", NameEn = "Insurance Services" },
                new FinancialService { Id = 5, NameAr = "قرض عقاري", NameEn = "Mortgage Loan" },
                new FinancialService { Id = 6, NameAr = "استثمار في الصناديق المشتركة", NameEn = "Mutual Fund Investment" },
                new FinancialService { Id = 7, NameAr = "حساب جاري", NameEn = "Current Account" },
                new FinancialService { Id = 8, NameAr = "قرض سيارة", NameEn = "Auto Loan" },
                new FinancialService { Id = 9, NameAr = "بطاقة مسبقة الدفع", NameEn = "Prepaid Card" },
                new FinancialService { Id = 10, NameAr = "تأمين على الممتلكات", NameEn = "Property Insurance" },
                new FinancialService { Id = 11, NameAr = "حساب استثماري", NameEn = "Investment Account" },
                new FinancialService { Id = 12, NameAr = "قرض تجاري", NameEn = "Business Loan" },
                new FinancialService { Id = 13, NameAr = "خدمات تحويل الأموال", NameEn = "Money Transfer Services" },
                new FinancialService { Id = 14, NameAr = "قرض تعليمي", NameEn = "Education Loan" },
                new FinancialService { Id = 15, NameAr = "خدمات إدارة الثروات", NameEn = "Wealth Management Services" },
                new FinancialService { Id = 16, NameAr = "خدمات التقاعد", NameEn = "Retirement Services" });

            modelBuilder.Entity<MisSellingCategory>().HasData(
                new MisSellingCategory { Id = 1, NameAr = "بيع منتجات غير مناسبة", NameEn = "Sale of Unsuitable Products" },
                new MisSellingCategory { Id = 2, NameAr = "إخفاء معلومات هامة", NameEn = "Omission of Key Information" },
                new MisSellingCategory { Id = 3, NameAr = "تقديم نصائح مضللة", NameEn = "Providing Misleading Advice" },
                new MisSellingCategory { Id = 4, NameAr = "ضغط مبيعات عالي", NameEn = "High-Pressure Sales Tactics" },
                new MisSellingCategory { Id = 5, NameAr = "عدم الإفصاح عن الرسوم", NameEn = "Failure to Disclose Fees" },
                new MisSellingCategory { Id = 6, NameAr = "تقديم وعود غير واقعية", NameEn = "Making Unrealistic Promises" },
                new MisSellingCategory { Id = 7, NameAr = "بيع منتجات غير مفهومة", NameEn = "Sale of Complex Products without Explanation" },
                new MisSellingCategory { Id = 8, NameAr = "تضليل حول المخاطر", NameEn = "Misrepresentation of Risks" },
                new MisSellingCategory { Id = 9, NameAr = "تضليل حول العوائد", NameEn = "Misrepresentation of Returns" },
                new MisSellingCategory { Id = 10, NameAr = "تضليل حول الشروط والأحكام", NameEn = "Misrepresentation of Terms and Conditions" },
                new MisSellingCategory { Id = 11, NameAr = "تضليل حول الأهلية", NameEn = "Misrepresentation of Eligibility" },
                new MisSellingCategory { Id = 12, NameAr = "بيع منتجات غير مرخصة", NameEn = "Sale of Unlicensed Products" },
                new MisSellingCategory { Id = 13, NameAr = "تضليل حول الفوائد", NameEn = "Misrepresentation of Benefits" },
                new MisSellingCategory { Id = 14, NameAr = "تضليل حول التكاليف", NameEn = "Misrepresentation of Costs" },
                new MisSellingCategory { Id = 15, NameAr = "تضليل حول الأداء السابق", NameEn = "Misrepresentation of Past Performance" },
                new MisSellingCategory { Id = 16, NameAr = "تضليل حول السيولة", NameEn = "Misrepresentation of Liquidity" },
                new MisSellingCategory { Id = 17, NameAr = "تضليل حول الضمانات", NameEn = "Misrepresentation of Guarantees" },
                new MisSellingCategory { Id = 18, NameAr = "تضليل حول التأمين", NameEn = "Misrepresentation of Insurance Coverage" },
                new MisSellingCategory { Id = 19, NameAr = "تضليل حول الاستثمارات", NameEn = "Misrepresentation of Investment Strategies" },
                new MisSellingCategory { Id = 20, NameAr = "تضليل حول الأصول", NameEn = "Misrepresentation of Asset Allocation" });

            modelBuilder.Entity<Bank>().HasData(
                new Bank { Id = 1, NameAr = "البنك الأهلي المصري", NameEn = "National Bank of Egypt" },
                new Bank { Id = 2, NameAr = "بنك مصر", NameEn = "Banque Misr" },
                new Bank { Id = 3, NameAr = "بنك القاهرة", NameEn = "Banque du Caire" },
                new Bank { Id = 4, NameAr = "البنك التجاري الدولي", NameEn = "Commercial International Bank" },
                new Bank { Id = 5, NameAr = "بنك الإسكندرية", NameEn = "Bank of Alexandria" },
                new Bank { Id = 6, NameAr = "بنك قناة السويس", NameEn = "Suez Canal Bank" },
                new Bank { Id = 7, NameAr = "البنك العربي الأفريقي الدولي", NameEn = "Arab African International Bank" },
                new Bank { Id = 8, NameAr = "بنك قطر الوطني الأهلي", NameEn = "Qatar National Bank Alahli" });

            modelBuilder.Entity<BankBranch>().HasData(
                new BankBranch { Id = 1, NameAr = "فرع القاهرة", NameEn = "Cairo Branch", BankId = 1 },
                new BankBranch { Id = 2, NameAr = "فرع الإسكندرية", NameEn = "Alexandria Branch", BankId = 1 },
                new BankBranch { Id = 3, NameAr = "فرع الجيزة", NameEn = "Giza Branch", BankId = 2 },
                new BankBranch { Id = 4, NameAr = "فرع المنصورة", NameEn = "Mansoura Branch", BankId = 2 },
                new BankBranch { Id = 5, NameAr = "فرع أسيوط", NameEn = "Asyut Branch", BankId = 3 },
                new BankBranch { Id = 6, NameAr = "فرع سوهاج", NameEn = "Sohag Branch", BankId = 3 },
                new BankBranch { Id = 7, NameAr = "فرع الأقصر", NameEn = "Luxor Branch", BankId = 4 },
                new BankBranch { Id = 8, NameAr = "فرع أسوان", NameEn = "Aswan Branch", BankId = 4 },
                new BankBranch { Id = 9, NameAr = "فرع بورسعيد", NameEn = "Port Said Branch", BankId = 5 },
                new BankBranch { Id = 10, NameAr = "فرع الإسماعيلية", NameEn = "Ismailia Branch", BankId = 6 },
                new BankBranch { Id = 11, NameAr = "فرع السويس", NameEn = "Suez Branch", BankId = 6 },
                new BankBranch { Id = 12, NameAr = "فرع المعادي", NameEn = "Maadi Branch", BankId = 7 },
                new BankBranch { Id = 13, NameAr = "فرع مدينة نصر", NameEn = "Nasr City Branch", BankId = 8 }
            );

            //Test Data Starts Here
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    FullName = "Ahmed Ali",
                    Gender = "M",
                    Birthdate = new DateTime(1985, 5, 20),
                    IdDocumentNumber = "28505201234567",
                    OfficialIdDocumentTypeId = 1,
                    EducationLevelId = 3,
                    EmploymentStatusId = 2,
                    MaritalStatusId = 3,
                    PhoneNumber = "01012345678",
                    Email = "ahmed.ali@example.com",
                    Occupation = "Software Engineer"
                },
                new Person
                {
                    Id = 2,
                    FullName = "Sara Mohamed",
                    Gender = "F",
                    Birthdate = new DateTime(1990, 8, 15),
                    IdDocumentNumber = "29008159876543",
                    OfficialIdDocumentTypeId = 1,
                    EducationLevelId = 2,
                    EmploymentStatusId = 1,
                    MaritalStatusId = 1,
                    PhoneNumber = "01234567890",
                    Email = "sara.mohamed@example.com",
                    Occupation = "Teacher"
                }
            );

            modelBuilder.Entity<Sme>().HasData(
                new Sme
                {
                    Id = 1,
                    Name = "Tech Solutions",
                    BusinessRegisterIdNumber = "BR1234567890",
                    TaxIdNumber = "581-945-545",
                    IndustrySector = "Information Technology",
                    LegalRepresentativePersonId = 1
                },
                new Sme
                {
                    Id = 2,
                    Name = "Green Farms",
                    BusinessRegisterIdNumber = "BR0987654321",
                    TaxIdNumber = "581-945-535",
                    IndustrySector = "Agriculture",
                    LegalRepresentativePersonId = 2
                }
            );

            modelBuilder.Entity<CbeCustomer>().HasData(
                new CbeCustomer
                {
                    Id = "000010649254",
                    CustomerTypeId = 1,
                    LatestCreditBureauReportingDate = new DateTime(2024, 1, 15),
                    LatestCreditBureauScore = 560,
                    PersonId = 1,
                    SmeId = null
                },
                new CbeCustomer
                {
                    Id = "000010649255",
                    CustomerTypeId = 1,
                    LatestCreditBureauReportingDate = new DateTime(2024, 2, 20),
                    LatestCreditBureauScore = 760,
                    PersonId = 2,
                    SmeId = null
                },
                new CbeCustomer
                {
                    Id = "000010649257",
                    CustomerTypeId = 2,
                    LatestCreditBureauReportingDate = new DateTime(2024, 3, 10),
                    LatestCreditBureauScore = 560,
                    PersonId = null,
                    SmeId = 1
                },
                new CbeCustomer
                {
                    Id = "000010649258",
                    CustomerTypeId = 2,
                    LatestCreditBureauReportingDate = new DateTime(2024, 4, 5),
                    LatestCreditBureauScore = 790,
                    PersonId = null,
                    SmeId = 2
                }
            );

            modelBuilder.Entity<CustomerRiskRateYearlyHistory>().HasData(
                // Good SME "000010649258"
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 3, Year = 2020, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 3, Year = 2021, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 3, Year = 2022, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 3, Year = 2023, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 3, Year = 2024, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 4, Year = 2020, Rate = 3 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 4, Year = 2021, Rate = 3 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 4, Year = 2022, Rate = 3 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 4, Year = 2023, Rate = 3 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649258", BankId = 4, Year = 2024, Rate = 3 },

                // Bad SME "000010649257"
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 3, Year = 2020, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 3, Year = 2021, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 3, Year = 2022, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 3, Year = 2023, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 3, Year = 2024, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 4, Year = 2020, Rate = 7 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 4, Year = 2021, Rate = 7 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 4, Year = 2022, Rate = 7 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 4, Year = 2023, Rate = 7 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649257", BankId = 4, Year = 2024, Rate = 7 },

                // Good Individual "000010649255"
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 1, Year = 2020, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 1, Year = 2021, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 1, Year = 2022, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 1, Year = 2023, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 1, Year = 2024, Rate = 2 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 2, Year = 2020, Rate = 3 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 2, Year = 2021, Rate = 3 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 2, Year = 2022, Rate = 3 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 2, Year = 2023, Rate = 3 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649255", BankId = 2, Year = 2024, Rate = 3 },

                // Bad Individual "000010649254"
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 1, Year = 2020, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 1, Year = 2021, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 1, Year = 2022, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 1, Year = 2023, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 1, Year = 2024, Rate = 8 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 2, Year = 2020, Rate = 7 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 2, Year = 2021, Rate = 7 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 2, Year = 2022, Rate = 7 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 2, Year = 2023, Rate = 7 },
                new CustomerRiskRateYearlyHistory { CbeCustomerId = "000010649254", BankId = 2, Year = 2024, Rate = 7 }
            );

            modelBuilder.Entity<CustomerCreditBureauReportingYearlyHistory>().HasData(
                // Good SME "000010649258"
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649258", Year = 2020, Score = 750 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649258", Year = 2021, Score = 760 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649258", Year = 2022, Score = 770 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649258", Year = 2023, Score = 780 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649258", Year = 2024, Score = 790 },

                // Bad SME "000010649257"
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649257", Year = 2020, Score = 600 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649257", Year = 2021, Score = 590 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649257", Year = 2022, Score = 580 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649257", Year = 2023, Score = 570 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649257", Year = 2024, Score = 560 },

                // Good Individual "000010649255"
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649255", Year = 2020, Score = 730 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649255", Year = 2021, Score = 730 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649255", Year = 2022, Score = 740 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649255", Year = 2023, Score = 750 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649255", Year = 2024, Score = 760 },

                // Bad Individual "000010649254"
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649254", Year = 2020, Score = 600 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649254", Year = 2021, Score = 590 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649254", Year = 2022, Score = 580 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649254", Year = 2023, Score = 570 },
                new CustomerCreditBureauReportingYearlyHistory { CbeCustomerId = "000010649254", Year = 2024, Score = 560 }
            );

            modelBuilder.Entity<SmeYearlyFinancialStatement>().HasData(
                // Good SME "000010649258"
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 3,
                    ReportingDate = new DateTime(2020, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 500000.00m,
                    Profit = 100000.00m,
                    TotalAssets = 700000.00m,
                    TotalEquity = 300000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 3,
                    ReportingDate = new DateTime(2021, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 550000.00m,
                    Profit = 110000.00m,
                    TotalAssets = 750000.00m,
                    TotalEquity = 350000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 3,
                    ReportingDate = new DateTime(2022, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 600000.00m,
                    Profit = 120000.00m,
                    TotalAssets = 800000.00m,
                    TotalEquity = 400000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 3,
                    ReportingDate = new DateTime(2023, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 650000.00m,
                    Profit = 130000.00m,
                    TotalAssets = 850000.00m,
                    TotalEquity = 450000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 3,
                    ReportingDate = new DateTime(2024, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 700000.00m,
                    Profit = 140000.00m,
                    TotalAssets = 900000.00m,
                    TotalEquity = 500000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 4,
                    ReportingDate = new DateTime(2020, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 520000.00m,
                    Profit = 104000.00m,
                    TotalAssets = 720000.00m,
                    TotalEquity = 320000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 4,
                    ReportingDate = new DateTime(2021, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 570000.00m,
                    Profit = 114000.00m,
                    TotalAssets = 770000.00m,
                    TotalEquity = 370000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 4,
                    ReportingDate = new DateTime(2022, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 620000.00m,
                    Profit = 124000.00m,
                    TotalAssets = 820000.00m,
                    TotalEquity = 420000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 4,
                    ReportingDate = new DateTime(2023, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 670000.00m,
                    Profit = 134000.00m,
                    TotalAssets = 870000.00m,
                    TotalEquity = 470000.00m,
                    TotalLiabilities = 400000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649258",
                    BankId = 4,
                    ReportingDate = new DateTime(2024, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 720000.00m,
                    Profit = 144000.00m,
                    TotalAssets = 920000.00m,
                    TotalEquity = 520000.00m,
                    TotalLiabilities = 400000.00m
                },

                // Bad SME "000010649257"
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649257",
                    BankId = 3,
                    ReportingDate = new DateTime(2024, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 220000.00m,
                    Profit = 0.00m,
                    TotalAssets = 320000.00m,
                    TotalEquity = 80000.00m,
                    TotalLiabilities = 240000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649257",
                    BankId = 4,
                    ReportingDate = new DateTime(2020, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 310000.00m,
                    Profit = 25000.00m,
                    TotalAssets = 410000.00m,
                    TotalEquity = 105000.00m,
                    TotalLiabilities = 305000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649257",
                    BankId = 4,
                    ReportingDate = new DateTime(2021, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 290000.00m,
                    Profit = 20000.00m,
                    TotalAssets = 390000.00m,
                    TotalEquity = 100000.00m,
                    TotalLiabilities = 290000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649257",
                    BankId = 4,
                    ReportingDate = new DateTime(2022, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 270000.00m,
                    Profit = 15000.00m,
                    TotalAssets = 370000.00m,
                    TotalEquity = 95000.00m,
                    TotalLiabilities = 275000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649257",
                    BankId = 4,
                    ReportingDate = new DateTime(2023, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 250000.00m,
                    Profit = 10000.00m,
                    TotalAssets = 350000.00m,
                    TotalEquity = 90000.00m,
                    TotalLiabilities = 260000.00m
                },
                new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = "000010649257",
                    BankId = 4,
                    ReportingDate = new DateTime(2024, 12, 31),
                    ReportingCurrencyId = 1,
                    Revenue = 230000.00m,
                    Profit = 5000.00m,
                    TotalAssets = 330000.00m,
                    TotalEquity = 85000.00m,
                    TotalLiabilities = 245000.00m
                }
            );

            modelBuilder.Entity<RetailAnnualIncome>().HasData(
                // Good Individual "000010649255"
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 1,
                    Year = 2020,
                    CurrencyId = 1,
                    Amount = 90000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 1,
                    Year = 2021,
                    CurrencyId = 1,
                    Amount = 95000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 1,
                    Year = 2022,
                    CurrencyId = 1,
                    Amount = 100000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 1,
                    Year = 2023,
                    CurrencyId = 1,
                    Amount = 105000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 1,
                    Year = 2024,
                    CurrencyId = 1,
                    Amount = 110000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 2,
                    Year = 2020,
                    CurrencyId = 1,
                    Amount = 92000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 2,
                    Year = 2021,
                    CurrencyId = 1,
                    Amount = 97000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 2,
                    Year = 2022,
                    CurrencyId = 1,
                    Amount = 102000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 2,
                    Year = 2023,
                    CurrencyId = 1,
                    Amount = 107000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649255",
                    BankId = 2,
                    Year = 2024,
                    CurrencyId = 1,
                    Amount = 112000.00m
                },

                // Bad Individual "000010649254"
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 1,
                    Year = 2020,
                    CurrencyId = 1,
                    Amount = 50000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 1,
                    Year = 2021,
                    CurrencyId = 1,
                    Amount = 48000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 1,
                    Year = 2022,
                    CurrencyId = 1,
                    Amount = 46000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 1,
                    Year = 2023,
                    CurrencyId = 1,
                    Amount = 44000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 1,
                    Year = 2024,
                    CurrencyId = 1,
                    Amount = 42000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 2,
                    Year = 2020,
                    CurrencyId = 1,
                    Amount = 52000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 2,
                    Year = 2021,
                    CurrencyId = 1,
                    Amount = 50000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 2,
                    Year = 2022,
                    CurrencyId = 1,
                    Amount = 48000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 2,
                    Year = 2023,
                    CurrencyId = 1,
                    Amount = 46000.00m
                },
                new RetailAnnualIncome
                {
                    CbeCustomerId = "000010649254",
                    BankId = 2,
                    Year = 2024,
                    CurrencyId = 1,
                    Amount = 44000.00m
                }
            );


            modelBuilder.Entity<Call>().HasData(
                //Good SME "000010649258" (Tech Solutions)
                //Call 1: Interested but can't afford (Mis-selling)
                new Call
                {
                    Id = Guid.NewGuid(),
                    CbeCustomerId = "000010649258",
                    BankId = 3,
                    BankBranchId = 1,
                    FinancialServiceId = 1,
                    MisSellingCategoryId = 1,
                    IsAiAnalysisFailed = false,
                    IsMisSellingDetected = true,
                    Transcript = "ألو، مساء الخير. أنا من بنك القاهرة، ممكن أتكلم مع حضرتك عن عرض التمويل الجديد للشركات الصغيرة والمتوسطة؟\n" +
                                 "مساء النور، اتفضل.\n" +
                                 "عندنا عرض تمويل بفائدة منخفضة لتمويل توسعات شركتك. العرض ده ممكن يساعدك في تطوير البنية التحتية وزيادة الإنتاج.\n" +
                                 "العرض ده ممتاز، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\n" +
                                 "ما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\n" +
                                 "طيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\n" +
                                 "ما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض."
                },
                //Call 2: Not interested and can't afford (Not Mis-selling)
                new Call
                {
                    Id = Guid.NewGuid(),
                    CbeCustomerId = "000010649258",
                    BankId = 3,
                    BankBranchId = 1,
                    FinancialServiceId = 1,
                    MisSellingCategoryId = null,
                    IsAiAnalysisFailed = false,
                    IsMisSellingDetected = false,
                    Transcript = "ألو، مساء الخير. أنا من بنك القاهرة، عندنا عرض تمويل جديد للشركات الصغيرة والمتوسطة.\n" +
                                 "مساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\n" +
                                 "العرض ده بفائدة منخفضة وممكن يساعدك في توسعات شركتك.\n" +
                                 "حتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\n" +
                                 "فاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين."
                },
                //Bad SME "000010649257" (Green Farms)
                //Call 1: Interested but can't afford (Mis-selling)
                new Call
                {
                    Id = Guid.NewGuid(),
                    CbeCustomerId = "000010649257",
                    BankId = 5,
                    BankBranchId = 2,
                    FinancialServiceId = 2,
                    MisSellingCategoryId = 1,
                    IsAiAnalysisFailed = false,
                    IsMisSellingDetected = true,
                    Transcript = "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\n" +
                                 "مساء النور، اتفضل.\n" +
                                 "العرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع وزيادة الإنتاج.\n" +
                                 "العرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\n" +
                                 "ما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\n" +
                                 "طيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\n" +
                                 "ما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض."
                },
                //Call 2: Not interested and can't afford (Not Mis-selling)
                new Call
                {
                    Id = Guid.NewGuid(),
                    CbeCustomerId = "000010649257",
                    BankId = 5,
                    BankBranchId = 2,
                    FinancialServiceId = 2,
                    MisSellingCategoryId = null,
                    IsAiAnalysisFailed = false,
                    IsMisSellingDetected = false,
                    Transcript = "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\n" +
                                 "مساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\n" +
                                 "العرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع.\n" +
                                 "حتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\n" +
                                 "فاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين."
                },
                //Good Individual "000010649255" (Sara Mohamed)
                //Call 1: Interested and can afford (Not Mis-selling)
                new Call
                {
                    Id = Guid.NewGuid(),
                    CbeCustomerId = "000010649255",
                    BankId = 1,
                    BankBranchId = 3,
                    FinancialServiceId = 3,
                    MisSellingCategoryId = null,
                    IsAiAnalysisFailed = false,
                    IsMisSellingDetected = false,
                    Transcript = "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\n" +
                                 "مساء النور، اتفضل.\n" +
                                 "البطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\n" +
                                 "العرض ده كويس، أنا مهتمة. إيه الإجراءات المطلوبة؟\n" +
                                 "هنحتاج بعض الأوراق البسيطة، وممكن نبدأ في الإجراءات فورًا.\n" +
                                 "تمام، هجهز الأوراق وأبعتهم لحضرتك."
                },
                //Call 2: Not interested but can afford (Mis-selling)
                new Call
                {
                    Id = Guid.NewGuid(),
                    CbeCustomerId = "000010649255",
                    BankId = 1,
                    BankBranchId = 3,
                    FinancialServiceId = 3,
                    MisSellingCategoryId = 2,
                    IsAiAnalysisFailed = false,
                    IsMisSellingDetected = true,
                    Transcript = "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\n" +
                                 "مساء النور، بس بصراحة مش مهتمة ببطاقات ائتمان جديدة دلوقتي.\n" +
                                 "البطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\n" +
                                 "حتى لو الفائدة منخفضة، أنا مش محتاجة بطاقة جديدة دلوقتي.\n" +
                                 "لازم تاخدي البطاقة دي، هتساعدك كتير في مصاريفك.\n" +
                                 "قلت لحضرتك مش مهتمة، شكراً."
                },
                //Bad Individual "000010649254" (Ahmed Ali)
                //Call 1: Interested but can't afford (Mis-selling)
                new Call
                {
                    Id = Guid.NewGuid(),
                    CbeCustomerId = "000010649254",
                    BankId = 2,
                    BankBranchId = 4,
                    FinancialServiceId = 4,
                    MisSellingCategoryId = 1,
                    IsAiAnalysisFailed = false,
                    IsMisSellingDetected = true,
                    Transcript = "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\n" +
                                    "مساء النور، اتفضل.\n" +
                                    "القرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\n" +
                                    "العرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لي أتحمل أي قروض جديدة دلوقتي.\n" +
                                    "ما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\n" +
                                    "طيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\n" +
                                    "ما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض."
                },
                //Call 2: Not interested and can't afford (Not Mis-selling)
                new Call
                {
                    Id = Guid.NewGuid(),
                    CbeCustomerId = "000010649254",
                    BankId = 2,
                    BankBranchId = 4,
                    FinancialServiceId = 4,
                    MisSellingCategoryId = null,
                    IsAiAnalysisFailed = false,
                    IsMisSellingDetected = false,
                    Transcript = "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\n" +
                                    "مساء النور، بس بصراحة مش مهتم بأي قروض جديدة دلوقتي.\n" +
                                    "القرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\n" +
                                    "حتى لو الفائدة منخفضة، أنا مش في وضع يسمح لي أتحمل أي قروض جديدة دلوقتي.\n" +
                                    "فاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين."
                });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
