using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
        public virtual DbSet<Cbecustomer> Cbecustomers { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; } = null!;
        public virtual DbSet<CustomerCreditBureauReportingYearlyHistory> CustomerCreditBureauReportingYearlyHistories { get; set; } = null!;
        public virtual DbSet<CustomerRiskRateYearlyHistory> CustomerRiskRateYearlyHistories { get; set; } = null!;
        public virtual DbSet<CustomerType> CustomerTypes { get; set; } = null!;
        public virtual DbSet<EducationLevel> EducationLevels { get; set; } = null!;
        public virtual DbSet<EmploymentStatus> EmploymentStatuses { get; set; } = null!;
        public virtual DbSet<FinancialService> FinancialServices { get; set; } = null!;
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; } = null!;
        public virtual DbSet<OfficialIdDocumentType> OfficialIdDocumentTypes { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<RetailAnnualIncome> RetailAnnualIncomes { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<Sme> Smes { get; set; } = null!;
        public virtual DbSet<SmeYearlyFinancialStatement> SmeYearlyFinancialStatements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CBE;User Id=sa;Password=Dev@123456;Persist Security Info=true;");
//            }
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
                    .HasConstraintName("FK__BankBranc__BankI__5812160E");
            });

            modelBuilder.Entity<Call>(entity =>
            {
                entity.ToTable("Call");

                entity.HasIndex(e => e.AgentId, "idx_Call_AgentId");

                entity.HasIndex(e => e.BankId, "idx_Call_BankId");

                entity.HasIndex(e => e.BranchId, "idx_Call_BranchId");

                entity.HasIndex(e => e.FinancialProductId, "idx_Call_FinancialProductId");

                entity.HasIndex(e => e.IsAianalysisFailed, "idx_Call_IsAIAnalysisFailed");

                entity.HasIndex(e => e.IsMisSellingDetected, "idx_Call_IsMisSellingDetected");

                entity.Property(e => e.AgentId).HasMaxLength(50);

                entity.Property(e => e.AgentName).HasMaxLength(500);

                entity.Property(e => e.CbecustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CBECustomerId");

                entity.Property(e => e.CustomerSatisfaction).HasMaxLength(20);

                entity.Property(e => e.GuidlinesForCustomer).HasMaxLength(500);

                entity.Property(e => e.IsAianalysisFailed).HasColumnName("IsAIAnalysisFailed");

                entity.Property(e => e.MisSellingDescription).HasMaxLength(500);

                entity.Property(e => e.RecommendedActionForBankOrRegulator).HasMaxLength(500);

                entity.Property(e => e.Transcript).HasColumnType("ntext");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Call__BankId__5DCAEF64");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Call__BranchId__5EBF139D");

                entity.HasOne(d => d.Cbecustomer)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.CbecustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Call__CBECustome__5CD6CB2B");

                entity.HasOne(d => d.FinancialProduct)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.FinancialProductId)
                    .HasConstraintName("FK__Call__FinancialP__5FB337D6");
            });

            modelBuilder.Entity<Cbecustomer>(entity =>
            {
                entity.ToTable("CBECustomer");

                entity.HasIndex(e => e.CustomerTypeId, "idx_CBECustomer_CustomerTypeId");

                entity.HasIndex(e => e.LatestCreditBureauReportingDate, "idx_CBECustomer_LatestCreditBureauReportingDate");

                entity.HasIndex(e => e.LatestCreditBureauScore, "idx_CBECustomer_LatestCreditBureauScore");

                entity.HasIndex(e => e.PersonId, "idx_CBECustomer_PersonId");

                entity.HasIndex(e => e.SmeId, "idx_CBECustomer_SmeId");

                entity.Property(e => e.Id)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LatestCreditBureauReportingDate).HasColumnType("date");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Cbecustomers)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CBECustom__Custo__398D8EEE");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Cbecustomers)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__CBECustom__Perso__3A81B327");

                entity.HasOne(d => d.Sme)
                    .WithMany(p => p.Cbecustomers)
                    .HasForeignKey(d => d.SmeId)
                    .HasConstraintName("FK__CBECustom__SmeId__3B75D760");
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

                entity.HasIndex(e => e.CbecustomerId, "idx_CustomerAddress_CBECustomerId");

                entity.HasIndex(e => e.TypeId, "idx_CustomerAddress_TypeId");

                entity.Property(e => e.CbecustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CBECustomerId");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Governorate).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OtherDetails).HasMaxLength(500);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cbecustomer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CbecustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerA__CBECu__5441852A");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerA__TypeI__5535A963");
            });

            modelBuilder.Entity<CustomerCreditBureauReportingYearlyHistory>(entity =>
            {
                entity.HasKey(e => new { e.CbecustomerId, e.Year })
                    .HasName("PK__Customer__37B96D868FD0B3BB");

                entity.ToTable("CustomerCreditBureauReportingYearlyHistory");

                entity.HasIndex(e => e.CbecustomerId, "idx_CustomerCreditBureauReportingYearlyHistory_CBECustomerId");

                entity.HasIndex(e => e.Score, "idx_CustomerCreditBureauReportingYearlyHistory_Score");

                entity.Property(e => e.CbecustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CBECustomerId");

                entity.HasOne(d => d.Cbecustomer)
                    .WithMany(p => p.CustomerCreditBureauReportingYearlyHistories)
                    .HasForeignKey(d => d.CbecustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerC__CBECu__440B1D61");
            });

            modelBuilder.Entity<CustomerRiskRateYearlyHistory>(entity =>
            {
                entity.HasKey(e => new { e.CbecustomerId, e.BankId, e.Year })
                    .HasName("PK__Customer__04868A5233C20CF8");

                entity.ToTable("CustomerRiskRateYearlyHistory");

                entity.HasIndex(e => e.CbecustomerId, "idx_CustomerRiskRateYearlyHistory_CBECustomerId");

                entity.Property(e => e.CbecustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CBECustomerId");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.CustomerRiskRateYearlyHistories)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerR__BankI__412EB0B6");

                entity.HasOne(d => d.Cbecustomer)
                    .WithMany(p => p.CustomerRiskRateYearlyHistories)
                    .HasForeignKey(d => d.CbecustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomerR__CBECu__403A8C7D");
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

                entity.HasIndex(e => new { e.IdDocumentNumber, e.OfficialIdDocumentTypeId }, "UQ__Person__6766F5EFE72AE447")
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
                    .HasConstraintName("FK__Person__Educatio__300424B4");

                entity.HasOne(d => d.EmploymentStatus)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.EmploymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Person__Employme__2E1BDC42");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Person__MaritalS__2D27B809");

                entity.HasOne(d => d.OfficialIdDocumentType)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.OfficialIdDocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Person__Official__2F10007B");
            });

            modelBuilder.Entity<RetailAnnualIncome>(entity =>
            {
                entity.HasKey(e => new { e.CbecustomerId, e.BankId, e.Year, e.CurrencyId })
                    .HasName("PK__RetailAn__AB97CE22E0BF26F0");

                entity.ToTable("RetailAnnualIncome");

                entity.HasIndex(e => e.BankId, "idx_RetailAnnualIncome_BankId");

                entity.HasIndex(e => e.CbecustomerId, "idx_RetailAnnualIncome_CBECustomerId");

                entity.HasIndex(e => e.CurrencyId, "idx_RetailAnnualIncome_CurrencyId");

                entity.Property(e => e.CbecustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CBECustomerId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.RetailAnnualIncomes)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RetailAnn__BankI__4E88ABD4");

                entity.HasOne(d => d.Cbecustomer)
                    .WithMany(p => p.RetailAnnualIncomes)
                    .HasForeignKey(d => d.CbecustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RetailAnn__CBECu__4D94879B");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.RetailAnnualIncomes)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RetailAnn__Curre__4F7CD00D");
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
                    .HasConstraintName("FK__Sme__LegalRepres__34C8D9D1");
            });

            modelBuilder.Entity<SmeYearlyFinancialStatement>(entity =>
            {
                entity.HasKey(e => new { e.CbecustomerId, e.BankId, e.ReportingDate })
                    .HasName("PK__SmeYearl__D2CC7D4AAF35AD8F");

                entity.ToTable("SmeYearlyFinancialStatement");

                entity.HasIndex(e => e.BankId, "idx_SmeYearlyFinancialStatement_BankId");

                entity.HasIndex(e => e.CbecustomerId, "idx_SmeYearlyFinancialStatement_CBECustomerId");

                entity.HasIndex(e => e.ReportingCurrencyId, "idx_SmeYearlyFinancialStatement_ReportingCurrencyId");

                entity.Property(e => e.CbecustomerId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CBECustomerId");

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
                    .HasConstraintName("FK__SmeYearly__BankI__49C3F6B7");

                entity.HasOne(d => d.Cbecustomer)
                    .WithMany(p => p.SmeYearlyFinancialStatements)
                    .HasForeignKey(d => d.CbecustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SmeYearly__CBECu__48CFD27E");

                entity.HasOne(d => d.ReportingCurrency)
                    .WithMany(p => p.SmeYearlyFinancialStatements)
                    .HasForeignKey(d => d.ReportingCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SmeYearly__Repor__4AB81AF0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
