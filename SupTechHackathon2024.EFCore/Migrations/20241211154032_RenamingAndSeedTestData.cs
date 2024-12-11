using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupTechHackathon2024.EFCore.Migrations
{
    public partial class RenamingAndSeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BankBranch",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Bank",
                newName: "NameEn");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "BankBranch",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Bank",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

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
                table: "Person",
                columns: new[] { "Id", "AlternativePhoneNumber", "Birthdate", "EducationLevelId", "Email", "EmploymentStatusId", "FullName", "Gender", "IdDocumentNumber", "MaritalStatusId", "Occupation", "OfficialIdDocumentTypeId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)3, "ahmed.ali@example.com", (short)2, "Ahmed Ali", "M", "28505201234567", (short)3, "Software Engineer", (short)1, "01012345678" },
                    { 2, null, new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)2, "sara.mohamed@example.com", (short)1, "Sara Mohamed", "F", "29008159876543", (short)1, "Teacher", (short)1, "01234567890" }
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
                table: "CbeCustomer",
                columns: new[] { "Id", "CustomerTypeId", "LatestCreditBureauReportingDate", "LatestCreditBureauScore", "PersonId", "SmeId" },
                values: new object[,]
                {
                    { "000010649254", (short)1, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)560, 1, null },
                    { "000010649255", (short)1, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)760, 2, null }
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
                table: "CbeCustomer",
                columns: new[] { "Id", "CustomerTypeId", "LatestCreditBureauReportingDate", "LatestCreditBureauScore", "PersonId", "SmeId" },
                values: new object[,]
                {
                    { "000010649257", (short)2, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)560, null, 1 },
                    { "000010649258", (short)2, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)790, null, 2 }
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
                    { 2, "000010649254", (short)1, (short)2020, 52000.00m },
                    { 2, "000010649254", (short)1, (short)2021, 50000.00m },
                    { 2, "000010649254", (short)1, (short)2022, 48000.00m },
                    { 2, "000010649254", (short)1, (short)2023, 46000.00m },
                    { 2, "000010649254", (short)1, (short)2024, 44000.00m }
                });

            migrationBuilder.InsertData(
                table: "RetailAnnualIncome",
                columns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year", "Amount" },
                values: new object[,]
                {
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
                    { 3, "000010649258", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 110000.00m, (short)1, 550000.00m, 750000.00m, 350000.00m, 400000.00m },
                    { 3, "000010649258", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 120000.00m, (short)1, 600000.00m, 800000.00m, 400000.00m, 400000.00m },
                    { 3, "000010649258", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 130000.00m, (short)1, 650000.00m, 850000.00m, 450000.00m, 400000.00m },
                    { 3, "000010649258", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 140000.00m, (short)1, 700000.00m, 900000.00m, 500000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 104000.00m, (short)1, 520000.00m, 720000.00m, 320000.00m, 400000.00m }
                });

            migrationBuilder.InsertData(
                table: "SmeYearlyFinancialStatement",
                columns: new[] { "BankId", "CbeCustomerId", "ReportingDate", "Profit", "ReportingCurrencyId", "Revenue", "TotalAssets", "TotalEquity", "TotalLiabilities" },
                values: new object[,]
                {
                    { 4, "000010649258", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 114000.00m, (short)1, 570000.00m, 770000.00m, 370000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 124000.00m, (short)1, 620000.00m, 820000.00m, 420000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 134000.00m, (short)1, 670000.00m, 870000.00m, 470000.00m, 400000.00m },
                    { 4, "000010649258", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 144000.00m, (short)1, 720000.00m, 920000.00m, 520000.00m, 400000.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BankBranch",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649254", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649254", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649254", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649254", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649254", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649255", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649255", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649255", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649255", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649255", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649257", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649257", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649257", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649257", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649257", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649258", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649258", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649258", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649258", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerCreditBureauReportingYearlyHistory",
                keyColumns: new[] { "CbeCustomerId", "Year" },
                keyValues: new object[] { "000010649258", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649257", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649257", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649257", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649257", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649257", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649257", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649257", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649257", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649257", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649257", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649258", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649258", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649258", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649258", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 3, "000010649258", (short)2024 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649258", (short)2020 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649258", (short)2021 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649258", (short)2022 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649258", (short)2023 });

            migrationBuilder.DeleteData(
                table: "CustomerRiskRateYearlyHistory",
                keyColumns: new[] { "BankId", "CbeCustomerId", "Year" },
                keyValues: new object[] { 4, "000010649258", (short)2024 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)1, (short)2020 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)1, (short)2021 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)1, (short)2022 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)1, (short)2023 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649254", (short)1, (short)2024 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)1, (short)2020 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)1, (short)2021 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)1, (short)2022 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)1, (short)2023 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649254", (short)1, (short)2024 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)1, (short)2020 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)1, (short)2021 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)1, (short)2022 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)1, (short)2023 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 1, "000010649255", (short)1, (short)2024 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)1, (short)2020 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)1, (short)2021 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)1, (short)2022 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)1, (short)2023 });

            migrationBuilder.DeleteData(
                table: "RetailAnnualIncome",
                keyColumns: new[] { "BankId", "CbeCustomerId", "CurrencyId", "Year" },
                keyValues: new object[] { 2, "000010649255", (short)1, (short)2024 });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 3, "000010649257", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649257", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649257", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649257", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649257", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649257", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 3, "000010649258", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 3, "000010649258", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 3, "000010649258", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 3, "000010649258", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 3, "000010649258", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649258", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649258", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649258", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649258", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "SmeYearlyFinancialStatement",
                keyColumns: new[] { "BankId", "CbeCustomerId", "ReportingDate" },
                keyValues: new object[] { 4, "000010649258", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CbeCustomer",
                keyColumn: "Id",
                keyValue: "000010649254");

            migrationBuilder.DeleteData(
                table: "CbeCustomer",
                keyColumn: "Id",
                keyValue: "000010649255");

            migrationBuilder.DeleteData(
                table: "CbeCustomer",
                keyColumn: "Id",
                keyValue: "000010649257");

            migrationBuilder.DeleteData(
                table: "CbeCustomer",
                keyColumn: "Id",
                keyValue: "000010649258");

            migrationBuilder.DeleteData(
                table: "Sme",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sme",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "BankBranch");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Bank");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "BankBranch",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Bank",
                newName: "Name");
        }
    }
}
