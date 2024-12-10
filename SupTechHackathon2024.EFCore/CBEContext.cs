using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
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

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<BankBranch>(entity =>
            {
                entity.ToTable("BankBranch");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(200);

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
                new CustomerType { Id = 1, NameAr = "أفراد", NameEn="Retail"},
                new CustomerType { Id = 2, NameAr = "شركات صغيرة ومتوسطة", NameEn="SMEs" });

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
                new OfficialIdDocumentType { Id = 1, NameAr = "بطاقة رقم قومي", NameEn="National Id Card"},
                new OfficialIdDocumentType { Id = 2, NameAr = "جواز سفر", NameEn="Passport" },
                new OfficialIdDocumentType { Id = 3, NameAr = "سجل تجاري", NameEn="Business Registeration Document" },
                new OfficialIdDocumentType { Id = 4, NameAr = "بطاقة ضريبية", NameEn="Tax Identification Document" });

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
