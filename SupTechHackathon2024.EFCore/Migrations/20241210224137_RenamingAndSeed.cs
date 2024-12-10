using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupTechHackathon2024.EFCore.Migrations
{
    public partial class RenamingAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__BankBranc__BankI__5812160E",
                table: "BankBranch");

            migrationBuilder.DropForeignKey(
                name: "FK__Call__BankId__5DCAEF64",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK__Call__BranchId__5EBF139D",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK__Call__CBECustome__5CD6CB2B",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK__Call__FinancialP__5FB337D6",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK__CBECustom__Custo__398D8EEE",
                table: "CBECustomer");

            migrationBuilder.DropForeignKey(
                name: "FK__CBECustom__Perso__3A81B327",
                table: "CBECustomer");

            migrationBuilder.DropForeignKey(
                name: "FK__CBECustom__SmeId__3B75D760",
                table: "CBECustomer");

            migrationBuilder.DropForeignKey(
                name: "FK__CustomerA__CBECu__5441852A",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK__CustomerA__TypeI__5535A963",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK__CustomerC__CBECu__440B1D61",
                table: "CustomerCreditBureauReportingYearlyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__CustomerR__BankI__412EB0B6",
                table: "CustomerRiskRateYearlyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__CustomerR__CBECu__403A8C7D",
                table: "CustomerRiskRateYearlyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__Person__Educatio__300424B4",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK__Person__Employme__2E1BDC42",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK__Person__MaritalS__2D27B809",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK__Person__Official__2F10007B",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK__RetailAnn__BankI__4E88ABD4",
                table: "RetailAnnualIncome");

            migrationBuilder.DropForeignKey(
                name: "FK__RetailAnn__CBECu__4D94879B",
                table: "RetailAnnualIncome");

            migrationBuilder.DropForeignKey(
                name: "FK__RetailAnn__Curre__4F7CD00D",
                table: "RetailAnnualIncome");

            migrationBuilder.DropForeignKey(
                name: "FK__Sme__LegalRepres__34C8D9D1",
                table: "Sme");

            migrationBuilder.DropForeignKey(
                name: "FK__SmeYearly__BankI__49C3F6B7",
                table: "SmeYearlyFinancialStatement");

            migrationBuilder.DropForeignKey(
                name: "FK__SmeYearly__CBECu__48CFD27E",
                table: "SmeYearlyFinancialStatement");

            migrationBuilder.DropForeignKey(
                name: "FK__SmeYearly__Repor__4AB81AF0",
                table: "SmeYearlyFinancialStatement");

            migrationBuilder.DropPrimaryKey(
                name: "PK__SmeYearl__D2CC7D4AAF35AD8F",
                table: "SmeYearlyFinancialStatement");

            migrationBuilder.DropPrimaryKey(
                name: "PK__RetailAn__AB97CE22E0BF26F0",
                table: "RetailAnnualIncome");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Customer__04868A5233C20CF8",
                table: "CustomerRiskRateYearlyHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Customer__37B96D868FD0B3BB",
                table: "CustomerCreditBureauReportingYearlyHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CBECustomer",
                table: "CBECustomer");

            migrationBuilder.DropIndex(
                name: "idx_Call_AgentId",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "AgentName",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "CustomerSatisfaction",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "GuidlinesForCustomer",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "MisSellingDescription",
                table: "Call");

            migrationBuilder.DropColumn(
                name: "RecommendedActionForBankOrRegulator",
                table: "Call");

            migrationBuilder.RenameTable(
                name: "CBECustomer",
                newName: "CbeCustomer");

            migrationBuilder.RenameColumn(
                name: "CBECustomerId",
                table: "SmeYearlyFinancialStatement",
                newName: "CbeCustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_SmeYearlyFinancialStatement_CBECustomerId",
                table: "SmeYearlyFinancialStatement",
                newName: "idx_SmeYearlyFinancialStatement_CbeCustomerId");

            migrationBuilder.RenameColumn(
                name: "CBECustomerId",
                table: "RetailAnnualIncome",
                newName: "CbeCustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_RetailAnnualIncome_CBECustomerId",
                table: "RetailAnnualIncome",
                newName: "idx_RetailAnnualIncome_CbeCustomerId");

            migrationBuilder.RenameIndex(
                name: "UQ__Person__6766F5EFE72AE447",
                table: "Person",
                newName: "UQ_Person");

            migrationBuilder.RenameColumn(
                name: "CBECustomerId",
                table: "CustomerRiskRateYearlyHistory",
                newName: "CbeCustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_CustomerRiskRateYearlyHistory_CBECustomerId",
                table: "CustomerRiskRateYearlyHistory",
                newName: "idx_CustomerRiskRateYearlyHistory_CbeCustomerId");

            migrationBuilder.RenameColumn(
                name: "CBECustomerId",
                table: "CustomerCreditBureauReportingYearlyHistory",
                newName: "CbeCustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_CustomerCreditBureauReportingYearlyHistory_CBECustomerId",
                table: "CustomerCreditBureauReportingYearlyHistory",
                newName: "idx_CustomerCreditBureauReportingYearlyHistory_CbeCustomerId");

            migrationBuilder.RenameColumn(
                name: "CBECustomerId",
                table: "CustomerAddress",
                newName: "CbeCustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_CustomerAddress_CBECustomerId",
                table: "CustomerAddress",
                newName: "idx_CustomerAddress_CbeCustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_CBECustomer_SmeId",
                table: "CbeCustomer",
                newName: "idx_CbeCustomer_SmeId");

            migrationBuilder.RenameIndex(
                name: "idx_CBECustomer_PersonId",
                table: "CbeCustomer",
                newName: "idx_CbeCustomer_PersonId");

            migrationBuilder.RenameIndex(
                name: "idx_CBECustomer_LatestCreditBureauScore",
                table: "CbeCustomer",
                newName: "idx_CbeCustomer_LatestCreditBureauScore");

            migrationBuilder.RenameIndex(
                name: "idx_CBECustomer_LatestCreditBureauReportingDate",
                table: "CbeCustomer",
                newName: "idx_CbeCustomer_LatestCreditBureauReportingDate");

            migrationBuilder.RenameIndex(
                name: "idx_CBECustomer_CustomerTypeId",
                table: "CbeCustomer",
                newName: "idx_CbeCustomer_CustomerTypeId");

            migrationBuilder.RenameColumn(
                name: "IsAIAnalysisFailed",
                table: "Call",
                newName: "IsAiAnalysisFailed");

            migrationBuilder.RenameColumn(
                name: "CBECustomerId",
                table: "Call",
                newName: "CbeCustomerId");

            migrationBuilder.RenameColumn(
                name: "FinancialProductId",
                table: "Call",
                newName: "MisSellingCategoryId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Call",
                newName: "BankBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Call_CBECustomerId",
                table: "Call",
                newName: "IX_Call_CbeCustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_Call_FinancialProductId",
                table: "Call",
                newName: "idx_Call_MisSellingCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "FinancialServiceId",
                table: "Call",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SmeYearlyFinancialStatement",
                table: "SmeYearlyFinancialStatement",
                columns: new[] { "CbeCustomerId", "BankId", "ReportingDate" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RetailAnnualIncome",
                table: "RetailAnnualIncome",
                columns: new[] { "CbeCustomerId", "BankId", "Year", "CurrencyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRiskRateYearlyHistory",
                table: "CustomerRiskRateYearlyHistory",
                columns: new[] { "CbeCustomerId", "BankId", "Year" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerCreditBureauReportingYearlyHistory",
                table: "CustomerCreditBureauReportingYearlyHistory",
                columns: new[] { "CbeCustomerId", "Year" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CbeCustomer",
                table: "CbeCustomer",
                column: "Id");

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
                    { 13, "خدمات تحويل الأموال", "Money Transfer Services" },
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
                    { 2, "إخفاء معلومات هامة", "Omission of Key Information" }
                });

            migrationBuilder.InsertData(
                table: "MisSellingCategory",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
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

            migrationBuilder.CreateIndex(
                name: "idx_Call_FinancialServiceId",
                table: "Call",
                column: "FinancialServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranch_BankId",
                table: "BankBranch",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Call_BankBranchId",
                table: "Call",
                column: "BankBranchId",
                principalTable: "BankBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Call_BankId",
                table: "Call",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Call_CbeCustomerId",
                table: "Call",
                column: "CbeCustomerId",
                principalTable: "CbeCustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Call_FinancialServiceId",
                table: "Call",
                column: "FinancialServiceId",
                principalTable: "FinancialService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Call_MisSellingCategoryId",
                table: "Call",
                column: "MisSellingCategoryId",
                principalTable: "MisSellingCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CbeCustomer_CustomerTypeId",
                table: "CbeCustomer",
                column: "CustomerTypeId",
                principalTable: "CustomerType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CbeCustomer_PersonId",
                table: "CbeCustomer",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CbeCustomer_SmeId",
                table: "CbeCustomer",
                column: "SmeId",
                principalTable: "Sme",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_CbeCustomerId",
                table: "CustomerAddress",
                column: "CbeCustomerId",
                principalTable: "CbeCustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_TypeId",
                table: "CustomerAddress",
                column: "TypeId",
                principalTable: "AddressType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCreditBureauReportingYearlyHistory_CbeCustomerId",
                table: "CustomerCreditBureauReportingYearlyHistory",
                column: "CbeCustomerId",
                principalTable: "CbeCustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRiskRateYearlyHistory_BankId",
                table: "CustomerRiskRateYearlyHistory",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRiskRateYearlyHistory_CbeCustomerId",
                table: "CustomerRiskRateYearlyHistory",
                column: "CbeCustomerId",
                principalTable: "CbeCustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_EducationLevelId",
                table: "Person",
                column: "EducationLevelId",
                principalTable: "EducationLevel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_EmploymentStatusId",
                table: "Person",
                column: "EmploymentStatusId",
                principalTable: "EmploymentStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_MaritalStatusId",
                table: "Person",
                column: "MaritalStatusId",
                principalTable: "MaritalStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_OfficialIdDocumentTypeId",
                table: "Person",
                column: "OfficialIdDocumentTypeId",
                principalTable: "OfficialIdDocumentType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RetailAnnualIncome_BankId",
                table: "RetailAnnualIncome",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RetailAnnualIncome_CbeCustomerId",
                table: "RetailAnnualIncome",
                column: "CbeCustomerId",
                principalTable: "CbeCustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RetailAnnualIncome_CurrencyId",
                table: "RetailAnnualIncome",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sme_LegalRepresentativePersonId",
                table: "Sme",
                column: "LegalRepresentativePersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SmeYearlyFinancialStatement_BankId",
                table: "SmeYearlyFinancialStatement",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SmeYearlyFinancialStatement_CbeCustomerId",
                table: "SmeYearlyFinancialStatement",
                column: "CbeCustomerId",
                principalTable: "CbeCustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SmeYearlyFinancialStatement_ReportingCurrencyId",
                table: "SmeYearlyFinancialStatement",
                column: "ReportingCurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranch_BankId",
                table: "BankBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_Call_BankBranchId",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK_Call_BankId",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK_Call_CbeCustomerId",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK_Call_FinancialServiceId",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK_Call_MisSellingCategoryId",
                table: "Call");

            migrationBuilder.DropForeignKey(
                name: "FK_CbeCustomer_CustomerTypeId",
                table: "CbeCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_CbeCustomer_PersonId",
                table: "CbeCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_CbeCustomer_SmeId",
                table: "CbeCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_CbeCustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_TypeId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCreditBureauReportingYearlyHistory_CbeCustomerId",
                table: "CustomerCreditBureauReportingYearlyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRiskRateYearlyHistory_BankId",
                table: "CustomerRiskRateYearlyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRiskRateYearlyHistory_CbeCustomerId",
                table: "CustomerRiskRateYearlyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_EducationLevelId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_EmploymentStatusId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_MaritalStatusId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_OfficialIdDocumentTypeId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_RetailAnnualIncome_BankId",
                table: "RetailAnnualIncome");

            migrationBuilder.DropForeignKey(
                name: "FK_RetailAnnualIncome_CbeCustomerId",
                table: "RetailAnnualIncome");

            migrationBuilder.DropForeignKey(
                name: "FK_RetailAnnualIncome_CurrencyId",
                table: "RetailAnnualIncome");

            migrationBuilder.DropForeignKey(
                name: "FK_Sme_LegalRepresentativePersonId",
                table: "Sme");

            migrationBuilder.DropForeignKey(
                name: "FK_SmeYearlyFinancialStatement_BankId",
                table: "SmeYearlyFinancialStatement");

            migrationBuilder.DropForeignKey(
                name: "FK_SmeYearlyFinancialStatement_CbeCustomerId",
                table: "SmeYearlyFinancialStatement");

            migrationBuilder.DropForeignKey(
                name: "FK_SmeYearlyFinancialStatement_ReportingCurrencyId",
                table: "SmeYearlyFinancialStatement");

            migrationBuilder.DropTable(
                name: "MisSellingCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SmeYearlyFinancialStatement",
                table: "SmeYearlyFinancialStatement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RetailAnnualIncome",
                table: "RetailAnnualIncome");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRiskRateYearlyHistory",
                table: "CustomerRiskRateYearlyHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerCreditBureauReportingYearlyHistory",
                table: "CustomerCreditBureauReportingYearlyHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CbeCustomer",
                table: "CbeCustomer");

            migrationBuilder.DropIndex(
                name: "idx_Call_FinancialServiceId",
                table: "Call");

            migrationBuilder.DeleteData(
                table: "AddressType",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "AddressType",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "AddressType",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)6);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)7);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)8);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)9);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: (short)10);

            migrationBuilder.DeleteData(
                table: "CustomerType",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "CustomerType",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "EducationLevel",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "EducationLevel",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "EducationLevel",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "EmploymentStatus",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "EmploymentStatus",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "EmploymentStatus",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FinancialService",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MaritalStatus",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "MaritalStatus",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "MaritalStatus",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "OfficialIdDocumentType",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "OfficialIdDocumentType",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "OfficialIdDocumentType",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "OfficialIdDocumentType",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DropColumn(
                name: "FinancialServiceId",
                table: "Call");

            migrationBuilder.RenameTable(
                name: "CbeCustomer",
                newName: "CBECustomer");

            migrationBuilder.RenameColumn(
                name: "CbeCustomerId",
                table: "SmeYearlyFinancialStatement",
                newName: "CBECustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_SmeYearlyFinancialStatement_CbeCustomerId",
                table: "SmeYearlyFinancialStatement",
                newName: "idx_SmeYearlyFinancialStatement_CBECustomerId");

            migrationBuilder.RenameColumn(
                name: "CbeCustomerId",
                table: "RetailAnnualIncome",
                newName: "CBECustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_RetailAnnualIncome_CbeCustomerId",
                table: "RetailAnnualIncome",
                newName: "idx_RetailAnnualIncome_CBECustomerId");

            migrationBuilder.RenameIndex(
                name: "UQ_Person",
                table: "Person",
                newName: "UQ__Person__6766F5EFE72AE447");

            migrationBuilder.RenameColumn(
                name: "CbeCustomerId",
                table: "CustomerRiskRateYearlyHistory",
                newName: "CBECustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_CustomerRiskRateYearlyHistory_CbeCustomerId",
                table: "CustomerRiskRateYearlyHistory",
                newName: "idx_CustomerRiskRateYearlyHistory_CBECustomerId");

            migrationBuilder.RenameColumn(
                name: "CbeCustomerId",
                table: "CustomerCreditBureauReportingYearlyHistory",
                newName: "CBECustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_CustomerCreditBureauReportingYearlyHistory_CbeCustomerId",
                table: "CustomerCreditBureauReportingYearlyHistory",
                newName: "idx_CustomerCreditBureauReportingYearlyHistory_CBECustomerId");

            migrationBuilder.RenameColumn(
                name: "CbeCustomerId",
                table: "CustomerAddress",
                newName: "CBECustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_CustomerAddress_CbeCustomerId",
                table: "CustomerAddress",
                newName: "idx_CustomerAddress_CBECustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_CbeCustomer_SmeId",
                table: "CBECustomer",
                newName: "idx_CBECustomer_SmeId");

            migrationBuilder.RenameIndex(
                name: "idx_CbeCustomer_PersonId",
                table: "CBECustomer",
                newName: "idx_CBECustomer_PersonId");

            migrationBuilder.RenameIndex(
                name: "idx_CbeCustomer_LatestCreditBureauScore",
                table: "CBECustomer",
                newName: "idx_CBECustomer_LatestCreditBureauScore");

            migrationBuilder.RenameIndex(
                name: "idx_CbeCustomer_LatestCreditBureauReportingDate",
                table: "CBECustomer",
                newName: "idx_CBECustomer_LatestCreditBureauReportingDate");

            migrationBuilder.RenameIndex(
                name: "idx_CbeCustomer_CustomerTypeId",
                table: "CBECustomer",
                newName: "idx_CBECustomer_CustomerTypeId");

            migrationBuilder.RenameColumn(
                name: "IsAiAnalysisFailed",
                table: "Call",
                newName: "IsAIAnalysisFailed");

            migrationBuilder.RenameColumn(
                name: "CbeCustomerId",
                table: "Call",
                newName: "CBECustomerId");

            migrationBuilder.RenameColumn(
                name: "MisSellingCategoryId",
                table: "Call",
                newName: "FinancialProductId");

            migrationBuilder.RenameColumn(
                name: "BankBranchId",
                table: "Call",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Call_CbeCustomerId",
                table: "Call",
                newName: "IX_Call_CBECustomerId");

            migrationBuilder.RenameIndex(
                name: "idx_Call_MisSellingCategoryId",
                table: "Call",
                newName: "idx_Call_FinancialProductId");

            migrationBuilder.AddColumn<string>(
                name: "AgentId",
                table: "Call",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AgentName",
                table: "Call",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerSatisfaction",
                table: "Call",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuidlinesForCustomer",
                table: "Call",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MisSellingDescription",
                table: "Call",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecommendedActionForBankOrRegulator",
                table: "Call",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__SmeYearl__D2CC7D4AAF35AD8F",
                table: "SmeYearlyFinancialStatement",
                columns: new[] { "CBECustomerId", "BankId", "ReportingDate" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__RetailAn__AB97CE22E0BF26F0",
                table: "RetailAnnualIncome",
                columns: new[] { "CBECustomerId", "BankId", "Year", "CurrencyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Customer__04868A5233C20CF8",
                table: "CustomerRiskRateYearlyHistory",
                columns: new[] { "CBECustomerId", "BankId", "Year" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Customer__37B96D868FD0B3BB",
                table: "CustomerCreditBureauReportingYearlyHistory",
                columns: new[] { "CBECustomerId", "Year" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CBECustomer",
                table: "CBECustomer",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "idx_Call_AgentId",
                table: "Call",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK__BankBranc__BankI__5812160E",
                table: "BankBranch",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Call__BankId__5DCAEF64",
                table: "Call",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Call__BranchId__5EBF139D",
                table: "Call",
                column: "BranchId",
                principalTable: "BankBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Call__CBECustome__5CD6CB2B",
                table: "Call",
                column: "CBECustomerId",
                principalTable: "CBECustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Call__FinancialP__5FB337D6",
                table: "Call",
                column: "FinancialProductId",
                principalTable: "FinancialService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CBECustom__Custo__398D8EEE",
                table: "CBECustomer",
                column: "CustomerTypeId",
                principalTable: "CustomerType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CBECustom__Perso__3A81B327",
                table: "CBECustomer",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CBECustom__SmeId__3B75D760",
                table: "CBECustomer",
                column: "SmeId",
                principalTable: "Sme",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CustomerA__CBECu__5441852A",
                table: "CustomerAddress",
                column: "CBECustomerId",
                principalTable: "CBECustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CustomerA__TypeI__5535A963",
                table: "CustomerAddress",
                column: "TypeId",
                principalTable: "AddressType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CustomerC__CBECu__440B1D61",
                table: "CustomerCreditBureauReportingYearlyHistory",
                column: "CBECustomerId",
                principalTable: "CBECustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CustomerR__BankI__412EB0B6",
                table: "CustomerRiskRateYearlyHistory",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__CustomerR__CBECu__403A8C7D",
                table: "CustomerRiskRateYearlyHistory",
                column: "CBECustomerId",
                principalTable: "CBECustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Person__Educatio__300424B4",
                table: "Person",
                column: "EducationLevelId",
                principalTable: "EducationLevel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Person__Employme__2E1BDC42",
                table: "Person",
                column: "EmploymentStatusId",
                principalTable: "EmploymentStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Person__MaritalS__2D27B809",
                table: "Person",
                column: "MaritalStatusId",
                principalTable: "MaritalStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Person__Official__2F10007B",
                table: "Person",
                column: "OfficialIdDocumentTypeId",
                principalTable: "OfficialIdDocumentType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__RetailAnn__BankI__4E88ABD4",
                table: "RetailAnnualIncome",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__RetailAnn__CBECu__4D94879B",
                table: "RetailAnnualIncome",
                column: "CBECustomerId",
                principalTable: "CBECustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__RetailAnn__Curre__4F7CD00D",
                table: "RetailAnnualIncome",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Sme__LegalRepres__34C8D9D1",
                table: "Sme",
                column: "LegalRepresentativePersonId",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__SmeYearly__BankI__49C3F6B7",
                table: "SmeYearlyFinancialStatement",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__SmeYearly__CBECu__48CFD27E",
                table: "SmeYearlyFinancialStatement",
                column: "CBECustomerId",
                principalTable: "CBECustomer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__SmeYearly__Repor__4AB81AF0",
                table: "SmeYearlyFinancialStatement",
                column: "ReportingCurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");
        }
    }
}
