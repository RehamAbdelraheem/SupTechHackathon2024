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
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK__BankBranc__BankI__5812160E",
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
                        name: "FK__Person__Educatio__300424B4",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Person__Employme__2E1BDC42",
                        column: x => x.EmploymentStatusId,
                        principalTable: "EmploymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Person__MaritalS__2D27B809",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Person__Official__2F10007B",
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
                        name: "FK__Sme__LegalRepres__34C8D9D1",
                        column: x => x.LegalRepresentativePersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CBECustomer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    CustomerTypeId = table.Column<short>(type: "smallint", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    SmeId = table.Column<int>(type: "int", nullable: true),
                    LatestCreditBureauScore = table.Column<short>(type: "smallint", nullable: true),
                    LatestCreditBureauReportingDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CBECustomer", x => x.Id);
                    table.ForeignKey(
                        name: "FK__CBECustom__Custo__398D8EEE",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CBECustom__Perso__3A81B327",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CBECustom__SmeId__3B75D760",
                        column: x => x.SmeId,
                        principalTable: "Sme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Call",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CBECustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    AgentId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AgentName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Transcript = table.Column<string>(type: "ntext", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAIAnalysisFailed = table.Column<bool>(type: "bit", nullable: true),
                    CustomerSatisfaction = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsMisSellingDetected = table.Column<bool>(type: "bit", nullable: true),
                    MisSellingDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RecommendedActionForBankOrRegulator = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GuidlinesForCustomer = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FinancialProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Call", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Call__BankId__5DCAEF64",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Call__BranchId__5EBF139D",
                        column: x => x.BranchId,
                        principalTable: "BankBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Call__CBECustome__5CD6CB2B",
                        column: x => x.CBECustomerId,
                        principalTable: "CBECustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Call__FinancialP__5FB337D6",
                        column: x => x.FinancialProductId,
                        principalTable: "FinancialService",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CBECustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
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
                        name: "FK__CustomerA__CBECu__5441852A",
                        column: x => x.CBECustomerId,
                        principalTable: "CBECustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CustomerA__TypeI__5535A963",
                        column: x => x.TypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerCreditBureauReportingYearlyHistory",
                columns: table => new
                {
                    CBECustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    Score = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__37B96D868FD0B3BB", x => new { x.CBECustomerId, x.Year });
                    table.ForeignKey(
                        name: "FK__CustomerC__CBECu__440B1D61",
                        column: x => x.CBECustomerId,
                        principalTable: "CBECustomer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerRiskRateYearlyHistory",
                columns: table => new
                {
                    CBECustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    Rate = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__04868A5233C20CF8", x => new { x.CBECustomerId, x.BankId, x.Year });
                    table.ForeignKey(
                        name: "FK__CustomerR__BankI__412EB0B6",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CustomerR__CBECu__403A8C7D",
                        column: x => x.CBECustomerId,
                        principalTable: "CBECustomer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RetailAnnualIncome",
                columns: table => new
                {
                    CBECustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    CurrencyId = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RetailAn__AB97CE22E0BF26F0", x => new { x.CBECustomerId, x.BankId, x.Year, x.CurrencyId });
                    table.ForeignKey(
                        name: "FK__RetailAnn__BankI__4E88ABD4",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__RetailAnn__CBECu__4D94879B",
                        column: x => x.CBECustomerId,
                        principalTable: "CBECustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__RetailAnn__Curre__4F7CD00D",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SmeYearlyFinancialStatement",
                columns: table => new
                {
                    CBECustomerId = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
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
                    table.PrimaryKey("PK__SmeYearl__D2CC7D4AAF35AD8F", x => new { x.CBECustomerId, x.BankId, x.ReportingDate });
                    table.ForeignKey(
                        name: "FK__SmeYearly__BankI__49C3F6B7",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__SmeYearly__CBECu__48CFD27E",
                        column: x => x.CBECustomerId,
                        principalTable: "CBECustomer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__SmeYearly__Repor__4AB81AF0",
                        column: x => x.ReportingCurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankBranch_BankId",
                table: "BankBranch",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_AgentId",
                table: "Call",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_BankId",
                table: "Call",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_BranchId",
                table: "Call",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_FinancialProductId",
                table: "Call",
                column: "FinancialProductId");

            migrationBuilder.CreateIndex(
                name: "idx_Call_IsAIAnalysisFailed",
                table: "Call",
                column: "IsAIAnalysisFailed");

            migrationBuilder.CreateIndex(
                name: "idx_Call_IsMisSellingDetected",
                table: "Call",
                column: "IsMisSellingDetected");

            migrationBuilder.CreateIndex(
                name: "IX_Call_CBECustomerId",
                table: "Call",
                column: "CBECustomerId");

            migrationBuilder.CreateIndex(
                name: "idx_CBECustomer_CustomerTypeId",
                table: "CBECustomer",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "idx_CBECustomer_LatestCreditBureauReportingDate",
                table: "CBECustomer",
                column: "LatestCreditBureauReportingDate");

            migrationBuilder.CreateIndex(
                name: "idx_CBECustomer_LatestCreditBureauScore",
                table: "CBECustomer",
                column: "LatestCreditBureauScore");

            migrationBuilder.CreateIndex(
                name: "idx_CBECustomer_PersonId",
                table: "CBECustomer",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "idx_CBECustomer_SmeId",
                table: "CBECustomer",
                column: "SmeId");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerAddress_CBECustomerId",
                table: "CustomerAddress",
                column: "CBECustomerId");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerAddress_TypeId",
                table: "CustomerAddress",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerCreditBureauReportingYearlyHistory_CBECustomerId",
                table: "CustomerCreditBureauReportingYearlyHistory",
                column: "CBECustomerId");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerCreditBureauReportingYearlyHistory_Score",
                table: "CustomerCreditBureauReportingYearlyHistory",
                column: "Score");

            migrationBuilder.CreateIndex(
                name: "idx_CustomerRiskRateYearlyHistory_CBECustomerId",
                table: "CustomerRiskRateYearlyHistory",
                column: "CBECustomerId");

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
                name: "UQ__Person__6766F5EFE72AE447",
                table: "Person",
                columns: new[] { "IdDocumentNumber", "OfficialIdDocumentTypeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_RetailAnnualIncome_BankId",
                table: "RetailAnnualIncome",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "idx_RetailAnnualIncome_CBECustomerId",
                table: "RetailAnnualIncome",
                column: "CBECustomerId");

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
                name: "idx_SmeYearlyFinancialStatement_CBECustomerId",
                table: "SmeYearlyFinancialStatement",
                column: "CBECustomerId");

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
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "CBECustomer");

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
