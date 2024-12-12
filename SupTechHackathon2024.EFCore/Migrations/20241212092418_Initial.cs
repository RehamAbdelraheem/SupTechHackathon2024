using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupTechHackathon2024.EFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevel",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentStatus",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MisSellingCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisSellingCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficialIdDocumentType",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialIdDocumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptBurdenRatio = table.Column<short>(type: "smallint", nullable: false),
                    MinLoanAllowedRiskRateInclusive = table.Column<short>(type: "smallint", nullable: false),
                    MaxLoanAllowedRiskRateInclusive = table.Column<short>(type: "smallint", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankBranch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankBranch_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "date", nullable: false),
                    MaritalStatusId = table.Column<short>(type: "smallint", nullable: false),
                    EmploymentStatusId = table.Column<short>(type: "smallint", nullable: false),
                    IdDocumentNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OfficialIdDocumentTypeId = table.Column<short>(type: "smallint", nullable: false),
                    EducationLevelId = table.Column<short>(type: "smallint", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AlternativePhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_EmploymentStatusId",
                        column: x => x.EmploymentStatusId,
                        principalTable: "EmploymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_OfficialIdDocumentTypeId",
                        column: x => x.OfficialIdDocumentTypeId,
                        principalTable: "OfficialIdDocumentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TaxIdNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BusinessRegisterIdNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LegalRepresentativePersonId = table.Column<int>(type: "int", nullable: false),
                    IndustrySector = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sme_LegalRepresentativePersonId",
                        column: x => x.LegalRepresentativePersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CbeCustomer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    CustomerTypeId = table.Column<short>(type: "smallint", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    SmeId = table.Column<int>(type: "int", nullable: true),
                    LatestCreditBureauScore = table.Column<short>(type: "smallint", nullable: true),
                    LatestCreditBureauReportingDate = table.Column<DateTime>(type: "date", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CbeCustomer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CbeCustomer_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CbeCustomer_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CbeCustomer_SmeId",
                        column: x => x.SmeId,
                        principalTable: "Sme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Call",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    CbeCustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    BankBranchId = table.Column<int>(type: "int", nullable: false),
                    Transcript = table.Column<string>(type: "ntext", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAiAnalysisFailed = table.Column<bool>(type: "bit", nullable: true),
                    IsMisSellingDetected = table.Column<bool>(type: "bit", nullable: true),
                    MisSellingCategoryId = table.Column<int>(type: "int", nullable: true),
                    FinancialServiceId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Call", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Call_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "BankBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Call_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Call_CbeCustomerId",
                        column: x => x.CbeCustomerId,
                        principalTable: "CbeCustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Call_FinancialServiceId",
                        column: x => x.FinancialServiceId,
                        principalTable: "FinancialService",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Call_MisSellingCategoryId",
                        column: x => x.MisSellingCategoryId,
                        principalTable: "MisSellingCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CbeCustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Governorate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeId = table.Column<short>(type: "smallint", nullable: false),
                    OtherDetails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_CbeCustomerId",
                        column: x => x.CbeCustomerId,
                        principalTable: "CbeCustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerAddress_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerCreditBureauReportingYearlyHistory",
                columns: table => new
                {
                    CbeCustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    Score = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCreditBureauReportingYearlyHistory", x => new { x.CbeCustomerId, x.Year });
                    table.ForeignKey(
                        name: "FK_CustomerCreditBureauReportingYearlyHistory_CbeCustomerId",
                        column: x => x.CbeCustomerId,
                        principalTable: "CbeCustomer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerRiskRateYearlyHistory",
                columns: table => new
                {
                    CbeCustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    Rate = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRiskRateYearlyHistory", x => new { x.CbeCustomerId, x.BankId, x.Year });
                    table.ForeignKey(
                        name: "FK_CustomerRiskRateYearlyHistory_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerRiskRateYearlyHistory_CbeCustomerId",
                        column: x => x.CbeCustomerId,
                        principalTable: "CbeCustomer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RetailAnnualIncome",
                columns: table => new
                {
                    CbeCustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    CurrencyId = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailAnnualIncome", x => new { x.CbeCustomerId, x.BankId, x.Year, x.CurrencyId });
                    table.ForeignKey(
                        name: "FK_RetailAnnualIncome_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RetailAnnualIncome_CbeCustomerId",
                        column: x => x.CbeCustomerId,
                        principalTable: "CbeCustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RetailAnnualIncome_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SmeYearlyFinancialStatement",
                columns: table => new
                {
                    CbeCustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    ReportingDate = table.Column<DateTime>(type: "date", nullable: false),
                    ReportingCurrencyId = table.Column<short>(type: "smallint", nullable: false),
                    TotalAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Profit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Revenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmeYearlyFinancialStatement", x => new { x.CbeCustomerId, x.BankId, x.ReportingDate });
                    table.ForeignKey(
                        name: "FK_SmeYearlyFinancialStatement_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SmeYearlyFinancialStatement_CbeCustomerId",
                        column: x => x.CbeCustomerId,
                        principalTable: "CbeCustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SmeYearlyFinancialStatement_ReportingCurrencyId",
                        column: x => x.ReportingCurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AddressType",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { (short)1, "عنوان دائم", "Permanent Address" },
                    { (short)2, "عنوان مؤقت", "Temporary Address" },
                    { (short)3, "عنوان حالي", "Current Address" }
                });

            migrationBuilder.InsertData(
                table: "Bank",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "البنك الأهلي المصري", "National Bank of Egypt" },
                    { 2, "بنك مصر", "Banque Misr" },
                    { 3, "بنك القاهرة", "Banque du Caire" },
                    { 4, "البنك التجاري الدولي", "Commercial International Bank" },
                    { 5, "بنك الإسكندرية", "Bank of Alexandria" },
                    { 6, "بنك قناة السويس", "Suez Canal Bank" },
                    { 7, "البنك العربي الأفريقي الدولي", "Arab African International Bank" },
                    { 8, "بنك قطر الوطني الأهلي", "Qatar National Bank Alahli" }
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { (short)1, "الجنيه المصري", "Egyptian Pound" },
                    { (short)2, "الدولار الأمريكي", "US Dollar" },
                    { (short)3, "اليورو", "Euro" },
                    { (short)4, "الين الياباني", "Japanese Yen" },
                    { (short)5, "الجنيه الإسترليني", "British Pound" },
                    { (short)6, "الريال السعودي", "Saudi Riyal" },
                    { (short)7, "الدرهم الإماراتي", "UAE Dirham" },
                    { (short)8, "الدينار الكويتي", "Kuwaiti Dinar" },
                    { (short)9, "الروبية الهندية", "Indian Rupee" },
                    { (short)10, "اليوان الصيني", "Chinese Yuan" }
                });

            migrationBuilder.InsertData(
                table: "CustomerType",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { (short)1, "أفراد", "Retail" },
                    { (short)2, "شركات صغيرة ومتوسطة", "SMEs" }
                });

            migrationBuilder.InsertData(
                table: "EducationLevel",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { (short)1, "بدون مؤهل (غير متعلم وحتى الإعدادية)", "Illiterate to Preparatory School" },
                    { (short)2, "مؤهل متوسط", "High School" },
                    { (short)3, "مؤهل عالي", "University or Postgraduate Degree" }
                });

            migrationBuilder.InsertData(
                table: "EmploymentStatus",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { (short)1, "لا يعمل", "Unemployed" },
                    { (short)2, "عمل بدخل ثابت", "Fixed Income Job" },
                    { (short)3, "عمل حر", "Self-Employed" }
                });

            migrationBuilder.InsertData(
                table: "FinancialService",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "بطاقة ائتمان", "Credit Card" },
                    { 2, "قرض شخصي", "Personal Loan" },
                    { 3, "حساب توفير", "Savings Account" },
                    { 4, "خدمات التأمين", "Insurance Services" },
                    { 5, "قرض عقاري", "Mortgage Loan" },
                    { 6, "استثمار في الصناديق المشتركة", "Mutual Fund Investment" },
                    { 7, "حساب جاري", "Current Account" },
                    { 8, "قرض سيارة", "Auto Loan" },
                    { 9, "بطاقة مسبقة الدفع", "Prepaid Card" },
                    { 10, "تأمين على الممتلكات", "Property Insurance" },
                    { 11, "حساب استثماري", "Investment Account" },
                    { 12, "قرض تجاري", "Business Loan" },
                    { 13, "خدمات تحويل الأموال", "Money Transfer Services" }
                });

            migrationBuilder.InsertData(
                table: "FinancialService",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 14, "قرض تعليمي", "Education Loan" },
                    { 15, "خدمات إدارة الثروات", "Wealth Management Services" },
                    { 16, "خدمات التقاعد", "Retirement Services" }
                });

            migrationBuilder.InsertData(
                table: "MaritalStatus",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { (short)1, "أعزب", "Single" },
                    { (short)2, "متزوج ولا يعول", "Married without Dependents" },
                    { (short)3, "متزوج ويعول", "Married with Dependents" }
                });

            migrationBuilder.InsertData(
                table: "MisSellingCategory",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, "بيع منتجات غير مناسبة", "Sale of Unsuitable Products" },
                    { 2, "إخفاء معلومات هامة", "Omission of Key Information" },
                    { 3, "تقديم نصائح مضللة", "Providing Misleading Advice" },
                    { 4, "ضغط مبيعات عالي", "High-Pressure Sales Tactics" },
                    { 5, "عدم الإفصاح عن الرسوم", "Failure to Disclose Fees" },
                    { 6, "تقديم وعود غير واقعية", "Making Unrealistic Promises" },
                    { 7, "بيع منتجات غير مفهومة", "Sale of Complex Products without Explanation" },
                    { 8, "تضليل حول المخاطر", "Misrepresentation of Risks" },
                    { 9, "تضليل حول العوائد", "Misrepresentation of Returns" },
                    { 10, "تضليل حول الشروط والأحكام", "Misrepresentation of Terms and Conditions" },
                    { 11, "تضليل حول الأهلية", "Misrepresentation of Eligibility" },
                    { 12, "بيع منتجات غير مرخصة", "Sale of Unlicensed Products" },
                    { 13, "تضليل حول الفوائد", "Misrepresentation of Benefits" },
                    { 14, "تضليل حول التكاليف", "Misrepresentation of Costs" },
                    { 15, "تضليل حول الأداء السابق", "Misrepresentation of Past Performance" },
                    { 16, "تضليل حول السيولة", "Misrepresentation of Liquidity" },
                    { 17, "تضليل حول الضمانات", "Misrepresentation of Guarantees" },
                    { 18, "تضليل حول التأمين", "Misrepresentation of Insurance Coverage" },
                    { 19, "تضليل حول الاستثمارات", "Misrepresentation of Investment Strategies" },
                    { 20, "تضليل حول الأصول", "Misrepresentation of Asset Allocation" }
                });

            migrationBuilder.InsertData(
                table: "OfficialIdDocumentType",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { (short)1, "بطاقة رقم قومي", "National Id Card" },
                    { (short)2, "جواز سفر", "Passport" },
                    { (short)3, "سجل تجاري", "Business Registeration Document" },
                    { (short)4, "بطاقة ضريبية", "Tax Identification Document" }
                });

            migrationBuilder.InsertData(
                table: "BankBranch",
                columns: new[] { "Id", "BankId", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, 1, "فرع القاهرة", "Cairo Branch" },
                    { 2, 1, "فرع الإسكندرية", "Alexandria Branch" },
                    { 3, 2, "فرع الجيزة", "Giza Branch" },
                    { 4, 2, "فرع المنصورة", "Mansoura Branch" },
                    { 5, 3, "فرع أسيوط", "Asyut Branch" },
                    { 6, 3, "فرع سوهاج", "Sohag Branch" },
                    { 7, 4, "فرع الأقصر", "Luxor Branch" },
                    { 8, 4, "فرع أسوان", "Aswan Branch" },
                    { 9, 5, "فرع بورسعيد", "Port Said Branch" },
                    { 10, 6, "فرع الإسماعيلية", "Ismailia Branch" },
                    { 11, 6, "فرع السويس", "Suez Branch" },
                    { 12, 7, "فرع المعادي", "Maadi Branch" },
                    { 13, 8, "فرع مدينة نصر", "Nasr City Branch" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "AlternativePhoneNumber", "Birthdate", "EducationLevelId", "Email", "EmploymentStatusId", "FullName", "Gender", "IdDocumentNumber", "MaritalStatusId", "Occupation", "OfficialIdDocumentTypeId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)3, "ahmed.ali@example.com", (short)2, "Ahmed Ali", "M", "28505201234567", (short)3, "Software Engineer", (short)1, "01012345678" },
                    { 2, null, new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)2, "sara.mohamed@example.com", (short)1, "Sara Mohamed", "F", "29008159876543", (short)1, "Teacher", (short)1, "01234567890" }
                });

            migrationBuilder.InsertData(
                table: "CbeCustomer",
                columns: new[] { "Id", "CreateBy", "CreateDate", "CustomerTypeId", "LatestCreditBureauReportingDate", "LatestCreditBureauScore", "ModifiedBy", "ModifiedDate", "PersonId", "SmeId", "Status" },
                values: new object[,]
                {
                    { "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)1, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)560, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 },
                    { "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)760, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Sme",
                columns: new[] { "Id", "BusinessRegisterIdNumber", "IndustrySector", "LegalRepresentativePersonId", "Name", "TaxIdNumber" },
                values: new object[,]
                {
                    { 1, "BR1234567890", "Information Technology", 1, "Tech Solutions", "581-945-545" },
                    { 2, "BR0987654321", "Agriculture", 2, "Green Farms", "581-945-535" }
                });

            migrationBuilder.InsertData(
                table: "Call",
                columns: new[] { "Id", "BankBranchId", "BankId", "CbeCustomerId", "CreateBy", "CreateDate", "EndTime", "FinancialServiceId", "IsAiAnalysisFailed", "IsMisSellingDetected", "MisSellingCategoryId", "ModifiedBy", "ModifiedDate", "StartTime", "Status", "Transcript" },
                values: new object[,]
                {
                    { new Guid("13335d0c-5011-49d0-9d47-0ff799e2a5a1"), 3, 1, "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\nمساء النور، اتفضل.\nالبطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\nالعرض ده كويس، أنا مهتمة. إيه الإجراءات المطلوبة؟\nهنحتاج بعض الأوراق البسيطة، وممكن نبدأ في الإجراءات فورًا.\nتمام، هجهز الأوراق وأبعتهم لحضرتك." },
                    { new Guid("1de2cbb9-5afd-4881-8f9a-5976cd9a1ca6"), 4, 2, "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\nمساء النور، اتفضل.\nالقرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\nالعرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لي أتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("c448cbae-f434-47b5-b9d4-eae911c151d4"), 3, 1, "000010649255", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من البنك الأهلي المصري، عندنا عرض جديد لبطاقة ائتمان بفائدة منخفضة.\nمساء النور، بس بصراحة مش مهتمة ببطاقات ائتمان جديدة دلوقتي.\nالبطاقة دي ممكن تساعدك في إدارة مصاريفك اليومية وتوفر لك عروض وخصومات حصرية.\nحتى لو الفائدة منخفضة، أنا مش محتاجة بطاقة جديدة دلوقتي.\nلازم تاخدي البطاقة دي، هتساعدك كتير في مصاريفك.\nقلت لحضرتك مش مهتمة، شكراً." },
                    { new Guid("d9a0d701-f3e7-4c27-9e3b-051f67b2f1f1"), 4, 2, "000010649254", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك مصر، عندنا عرض جديد لقرض شخصي بفائدة منخفضة.\nمساء النور، بس بصراحة مش مهتم بأي قروض جديدة دلوقتي.\nالقرض ده ممكن يساعدك في تغطية مصاريفك الشخصية أو أي احتياجات طارئة.\nحتى لو الفائدة منخفضة، أنا مش في وضع يسمح لي أتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." }
                });

            migrationBuilder.InsertData(
                table: "CbeCustomer",
                columns: new[] { "Id", "CreateBy", "CreateDate", "CustomerTypeId", "LatestCreditBureauReportingDate", "LatestCreditBureauScore", "ModifiedBy", "ModifiedDate", "PersonId", "SmeId", "Status" },
                values: new object[,]
                {
                    { "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)2, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)560, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 0 },
                    { "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)2, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)790, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                columns: new[] { "CbeCustomerId", "Year", "Score" },
                values: new object[,]
                {
                    { "000010649254", (short)2020, (short)600 },
                    { "000010649254", (short)2021, (short)590 },
                    { "000010649254", (short)2022, (short)580 },
                    { "000010649254", (short)2023, (short)570 },
                    { "000010649254", (short)2024, (short)560 },
                    { "000010649255", (short)2020, (short)730 },
                    { "000010649255", (short)2021, (short)730 },
                    { "000010649255", (short)2022, (short)740 },
                    { "000010649255", (short)2023, (short)750 },
                    { "000010649255", (short)2024, (short)760 }
                });

            migrationBuilder.InsertData(
                table: "CustomerRiskRateYearlyHistory",
                columns: new[] { "BankId", "CbeCustomerId", "Year", "Rate" },
                values: new object[,]
                {
                    { 1, "000010649254", (short)2020, (short)8 },
                    { 1, "000010649254", (short)2021, (short)8 },
                    { 1, "000010649254", (short)2022, (short)8 },
                    { 1, "000010649254", (short)2023, (short)8 },
                    { 1, "000010649254", (short)2024, (short)8 },
                    { 2, "000010649254", (short)2020, (short)7 },
                    { 2, "000010649254", (short)2021, (short)7 },
                    { 2, "000010649254", (short)2022, (short)7 },
                    { 2, "000010649254", (short)2023, (short)7 },
                    { 2, "000010649254", (short)2024, (short)7 },
                    { 1, "000010649255", (short)2020, (short)2 },
                    { 1, "000010649255", (short)2021, (short)2 },
                    { 1, "000010649255", (short)2022, (short)2 },
                    { 1, "000010649255", (short)2023, (short)2 },
                    { 1, "000010649255", (short)2024, (short)2 },
                    { 2, "000010649255", (short)2020, (short)3 },
                    { 2, "000010649255", (short)2021, (short)3 },
                    { 2, "000010649255", (short)2022, (short)3 },
                    { 2, "000010649255", (short)2023, (short)3 },
                    { 2, "000010649255", (short)2024, (short)3 }
                });

            migrationBuilder.InsertData(
                table: "RetailAnnualIncome",
                columns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year", "Amount" },
                values: new object[,]
                {
                    { 1, "000010649254", (short)1, (short)2020, 50000.00m },
                    { 1, "000010649254", (short)1, (short)2021, 48000.00m },
                    { 1, "000010649254", (short)1, (short)2022, 46000.00m },
                    { 1, "000010649254", (short)1, (short)2023, 44000.00m },
                    { 1, "000010649254", (short)1, (short)2024, 42000.00m },
                    { 2, "000010649254", (short)1, (short)2020, 52000.00m }
                });

            migrationBuilder.InsertData(
                table: "RetailAnnualIncome",
                columns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year", "Amount" },
                values: new object[,]
                {
                    { 2, "000010649254", (short)1, (short)2021, 50000.00m },
                    { 2, "000010649254", (short)1, (short)2022, 48000.00m },
                    { 2, "000010649254", (short)1, (short)2023, 46000.00m },
                    { 2, "000010649254", (short)1, (short)2024, 44000.00m },
                    { 1, "000010649255", (short)1, (short)2020, 90000.00m },
                    { 1, "000010649255", (short)1, (short)2021, 95000.00m },
                    { 1, "000010649255", (short)1, (short)2022, 100000.00m },
                    { 1, "000010649255", (short)1, (short)2023, 105000.00m },
                    { 1, "000010649255", (short)1, (short)2024, 110000.00m },
                    { 2, "000010649255", (short)1, (short)2020, 92000.00m },
                    { 2, "000010649255", (short)1, (short)2021, 97000.00m },
                    { 2, "000010649255", (short)1, (short)2022, 102000.00m },
                    { 2, "000010649255", (short)1, (short)2023, 107000.00m },
                    { 2, "000010649255", (short)1, (short)2024, 112000.00m }
                });

            migrationBuilder.InsertData(
                table: "Call",
                columns: new[] { "Id", "BankBranchId", "BankId", "CbeCustomerId", "CreateBy", "CreateDate", "EndTime", "FinancialServiceId", "IsAiAnalysisFailed", "IsMisSellingDetected", "MisSellingCategoryId", "ModifiedBy", "ModifiedDate", "StartTime", "Status", "Transcript" },
                values: new object[,]
                {
                    { new Guid("68d1ba0a-4979-4083-94c6-232857c0d07f"), 1, 3, "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك القاهرة، ممكن أتكلم مع حضرتك عن عرض التمويل الجديد للشركات الصغيرة والمتوسطة؟\nمساء النور، اتفضل.\nعندنا عرض تمويل بفائدة منخفضة لتمويل توسعات شركتك. العرض ده ممكن يساعدك في تطوير البنية التحتية وزيادة الإنتاج.\nالعرض ده ممتاز، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("b4e778f4-bf7c-4c27-b034-3fb6c6c18bd1"), 1, 3, "000010649258", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك القاهرة، عندنا عرض تمويل جديد للشركات الصغيرة والمتوسطة.\nمساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\nالعرض ده بفائدة منخفضة وممكن يساعدك في توسعات شركتك.\nحتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." },
                    { new Guid("e20f0191-5e18-4362-871b-7bc40f435fb2"), 2, 5, "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\nمساء النور، اتفضل.\nالعرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع وزيادة الإنتاج.\nالعرض ده كويس، بس بصراحة الميزانية الحالية مش هتسمح لنا نتحمل أي قروض جديدة دلوقتي.\nما تقلقش، إحنا هنساعدك في ترتيب خطة دفع مريحة حتى لو مش هتقدر تلتزم بيها دلوقتي.\nطيب، ممكن نتكلم في التفاصيل أكتر، بس مش متأكد إني هقدر ألتزم دلوقتي.\nما فيش مشكلة، المهم إنك تبدأ وتستفيد من العرض." },
                    { new Guid("ecff67c3-a4aa-4480-a2f6-409501d6f7db"), 2, 5, "000010649257", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, false, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ألو، مساء الخير. أنا من بنك الإسكندرية، عندنا عرض تمويل جديد للشركات الزراعية.\nمساء النور، بس بصراحة مش مهتمين بأي تمويل جديد دلوقتي.\nالعرض ده بفائدة منخفضة وممكن يساعدك في تطوير المزارع.\nحتى لو الفائدة منخفضة، إحنا مش في وضع يسمح لنا نتحمل أي قروض جديدة دلوقتي.\nفاهم، لو احتجت أي مساعدة في المستقبل، إحنا موجودين." }
                });

            migrationBuilder.InsertData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                columns: new[] { "CbeCustomerId", "Year", "Score" },
                values: new object[,]
                {
                    { "000010649257", (short)2020, (short)600 },
                    { "000010649257", (short)2021, (short)590 },
                    { "000010649257", (short)2022, (short)580 },
                    { "000010649257", (short)2023, (short)570 },
                    { "000010649257", (short)2024, (short)560 },
                    { "000010649258", (short)2020, (short)750 },
                    { "000010649258", (short)2021, (short)760 },
                    { "000010649258", (short)2022, (short)770 },
                    { "000010649258", (short)2023, (short)780 },
                    { "000010649258", (short)2024, (short)790 }
                });

            migrationBuilder.InsertData(
                table: "CustomerRiskRateYearlyHistory",
                columns: new[] { "BankId", "CbeCustomerId", "Year", "Rate" },
                values: new object[,]
                {
                    { 3, "000010649257", (short)2020, (short)8 },
                    { 3, "000010649257", (short)2021, (short)8 },
                    { 3, "000010649257", (short)2022, (short)8 },
                    { 3, "000010649257", (short)2023, (short)8 },
                    { 3, "000010649257", (short)2024, (short)8 },
                    { 4, "000010649257", (short)2020, (short)7 },
                    { 4, "000010649257", (short)2021, (short)7 },
                    { 4, "000010649257", (short)2022, (short)7 },
                    { 4, "000010649257", (short)2023, (short)7 },
                    { 4, "000010649257", (short)2024, (short)7 },
                    { 3, "000010649258", (short)2020, (short)2 },
                    { 3, "000010649258", (short)2021, (short)2 },
                    { 3, "000010649258", (short)2022, (short)2 },
                    { 3, "000010649258", (short)2023, (short)2 },
                    { 3, "000010649258", (short)2024, (short)2 },
                    { 4, "000010649258", (short)2020, (short)3 },
                    { 4, "000010649258", (short)2021, (short)3 },
                    { 4, "000010649258", (short)2022, (short)3 },
                    { 4, "000010649258", (short)2023, (short)3 },
                    { 4, "000010649258", (short)2024, (short)3 }
                });

            migrationBuilder.InsertData(
                table: "SmeYearlyFinancialStatement",
                columns: new[] { "BankId", "CbeCustomerId", "ReportingDate", "Profit", "ReportingCurrencyId", "Revenue", "TotalAssets", "TotalEquity", "TotalLiabilities" },
                values: new object[,]
                {
                    { 3, "000010649257", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.00m, (short)1, 220000.00m, 320000.00m, 80000.00m, 240000.00m },
                    { 4, "000010649257", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 25000.00m, (short)1, 310000.00m, 410000.00m, 105000.00m, 305000.00m },
                    { 4, "000010649257", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000.00m, (short)1, 290000.00m, 390000.00m, 100000.00m, 290000.00m },
                    { 4, "000010649257", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000.00m, (short)1, 270000.00m, 370000.00m, 95000.00m, 275000.00m },
                    { 4, "000010649257", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000.00m, (short)1, 250000.00m, 350000.00m, 90000.00m, 260000.00m },
                    { 4, "000010649257", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000.00m, (short)1, 230000.00m, 330000.00m, 85000.00m, 245000.00m },
                    { 3, "000010649258", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 100000.00m, (short)1, 500000.00m, 700000.00m, 300000.00m, 400000.00m },
                    { 3, "000010649258", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 110000.00m, (short)1, 550000.00m, 750000.00m, 350000.00m, 400000.00m }
                });

            migrationBuilder.InsertData(
                table: "SmeYearlyFinancialStatement",
                columns: new[] { "BankId", "CbeCustomerId", "ReportingDate", "Profit", "ReportingCurrencyId", "Revenue", "TotalAssets", "TotalEquity", "TotalLiabilities" },
                values: new object[,]
                {
                    { 3, "000010649258", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 120000.00m, (short)1, 600000.00m, 800000.00m, 400000.00m, 400000.00m },
                    { 3, "000010649258", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 130000.00m, (short)1, 650000.00m, 850000.00m, 450000.00m, 400000.00m },
                    { 3, "000010649258", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 140000.00m, (short)1, 700000.00m, 900000.00m, 500000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 104000.00m, (short)1, 520000.00m, 720000.00m, 320000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 114000.00m, (short)1, 570000.00m, 770000.00m, 370000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 124000.00m, (short)1, 620000.00m, 820000.00m, 420000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 134000.00m, (short)1, 670000.00m, 870000.00m, 470000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 144000.00m, (short)1, 720000.00m, 920000.00m, 520000.00m, 400000.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankBranch_BankId",
                table: "BankBranch",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_BankId",
                table: "Call",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_BranchId",
                table: "Call",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_FinancialServiceId",
                table: "Call",
                column: "FinancialServiceId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_IsAIAnalysisFailed",
                table: "Call",
                column: "IsAiAnalysisFailed");

            migrationBuilder.CreateIndex(
                name: "idx_Call_IsMisSellingDetected",
                table: "Call",
                column: "IsMisSellingDetected");

            migrationBuilder.CreateIndex(
                name: "idx_Call_MisSellingCategoryId",
                table: "Call",
                column: "MisSellingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Call_CbeCustomerId",
                table: "Call",
                column: "CbeCustomerId");

            migrationBuilder.CreateIndex(
                name: "idx_CbeCustomer_CustomerTypeId",
                table: "CbeCustomer",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "idx_CbeCustomer_LatestCreditBureauReportingDate",
                table: "CbeCustomer",
                column: "LatestCreditBureauReportingDate");

            migrationBuilder.CreateIndex(
                name: "idx_CbeCustomer_LatestCreditBureauScore",
                table: "CbeCustomer",
                column: "LatestCreditBureauScore");

            migrationBuilder.CreateIndex(
                name: "idx_CbeCustomer_PersonId",
                table: "CbeCustomer",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "idx_CbeCustomer_SmeId",
                table: "CbeCustomer",
                column: "SmeId");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerAddress_CbeCustomerId",
                table: "CustomerAddress",
                column: "CbeCustomerId");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerAddress_TypeId",
                table: "CustomerAddress",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerCreditBureauReportingYearlyHistory_CbeCustomerId",
                table: "CustomerCreditBureauReportingYearlyHistory",
                column: "CbeCustomerId");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerCreditBureauReportingYearlyHistory_Score",
                table: "CustomerCreditBureauReportingYearlyHistory",
                column: "Score");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerRiskRateYearlyHistory_CbeCustomerId",
                table: "CustomerRiskRateYearlyHistory",
                column: "CbeCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRiskRateYearlyHistory_BankId",
                table: "CustomerRiskRateYearlyHistory",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "idx_Person_EducationLevelId",
                table: "Person",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "idx_Person_EmploymentStatusId",
                table: "Person",
                column: "EmploymentStatusId");

            migrationBuilder.CreateIndex(
                name: "idx_Person_Gender",
                table: "Person",
                column: "Gender");

            migrationBuilder.CreateIndex(
                name: "idx_Person_IdDocumentNumber",
                table: "Person",
                column: "IdDocumentNumber");

            migrationBuilder.CreateIndex(
                name: "idx_Person_MaritalStatusId",
                table: "Person",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "idx_Person_OfficialIdDocumentTypeId",
                table: "Person",
                column: "OfficialIdDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "UQ_Person",
                table: "Person",
                columns: new[] { "IdDocumentNumber", "OfficialIdDocumentTypeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_RetailAnnualIncome_BankId",
                table: "RetailAnnualIncome",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "idx_RetailAnnualIncome_CbeCustomerId",
                table: "RetailAnnualIncome",
                column: "CbeCustomerId");

            migrationBuilder.CreateIndex(
                name: "idx_RetailAnnualIncome_CurrencyId",
                table: "RetailAnnualIncome",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "idx_Sme_BusinessRegisterIdNumber",
                table: "Sme",
                column: "BusinessRegisterIdNumber");

            migrationBuilder.CreateIndex(
                name: "idx_Sme_LegalRepresentativePersonId",
                table: "Sme",
                column: "LegalRepresentativePersonId");

            migrationBuilder.CreateIndex(
                name: "idx_Sme_TaxIdNumber",
                table: "Sme",
                column: "TaxIdNumber");

            migrationBuilder.CreateIndex(
                name: "idx_SmeYearlyFinancialStatement_BankId",
                table: "SmeYearlyFinancialStatement",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "idx_SmeYearlyFinancialStatement_CbeCustomerId",
                table: "SmeYearlyFinancialStatement",
                column: "CbeCustomerId");

            migrationBuilder.CreateIndex(
                name: "idx_SmeYearlyFinancialStatement_ReportingCurrencyId",
                table: "SmeYearlyFinancialStatement",
                column: "ReportingCurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Call");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "CustomerCreditBureauReportingYearlyHistory");

            migrationBuilder.DropTable(
                name: "CustomerRiskRateYearlyHistory");

            migrationBuilder.DropTable(
                name: "RetailAnnualIncome");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "SmeYearlyFinancialStatement");

            migrationBuilder.DropTable(
                name: "BankBranch");

            migrationBuilder.DropTable(
                name: "FinancialService");

            migrationBuilder.DropTable(
                name: "MisSellingCategory");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "CbeCustomer");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "CustomerType");

            migrationBuilder.DropTable(
                name: "Sme");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "EducationLevel");

            migrationBuilder.DropTable(
                name: "EmploymentStatus");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "OfficialIdDocumentType");
        }
    }
}
