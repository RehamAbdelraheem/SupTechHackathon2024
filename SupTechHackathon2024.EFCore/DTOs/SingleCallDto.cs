
namespace SupTechHackathon2024.EFCore.Dtos
{
    public class SingleCallDto
    {
        public Guid Id { get; set; }
        public string CbeCustomerId { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<string> Products { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string Transcript { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string CustomerTypeName { get; set; }
        public IEnumerable<CustomerAddressDto> CustomerAddresses { get; set; }
        public IEnumerable<RiskRateHistoryDto> CustomerRiskRateYearlyHistory { get; set; }
        public IEnumerable<CreditBureauHistoryDto> CustomerCreditBureauReportingYearlyHistory { get; set; }
        public PersonDto Person { get; set; }
        public SmeDto Sme { get; set; }
        public IEnumerable<AnnualIncomeDto> LastFiveYearsAnnualIncome { get; set; }
    }

    public class CustomerAddressDto
    {
        public string Country { get; set; }
        public string Governorate { get; set; }
        public string City { get; set; }
        public string OtherDetails { get; set; }
        public string PostalCode { get; set; }
    }

    public class RiskRateHistoryDto
    {
        public string BankName { get; set; }
        public int Rate { get; set; }
        public int Year { get; set; }
    }

    public class CreditBureauHistoryDto
    {
        public int Score { get; set; }
        public int Year { get; set; }
    }

    public class PersonDto
    {
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string MaritalStatusName { get; set; }
        public string EmploymentStatusName { get; set; }
        public string EducationLevelName { get; set; }
        public string Occupation { get; set; }

    }

    public class AnnualIncomeDto
    {
        public string BankName { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyName { get; set; }
    }
    public class SmeDto
    {
        public string IndustrySector { get; set; }
        public IEnumerable<SmeYearlyFinancialStatementDto> YearlyFinancialStatement { get; set; }
    }

    public class SmeYearlyFinancialStatementDto
    {
        public string BankName { get; set; }
        public DateTime ReportingDate { get; set; }
        public string ReportingCurrencyName { get; set; }
        public decimal TotalAssets { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal TotalEquity { get; set; }
        public decimal Profit { get; set; }
        public decimal Revenue { get; set; }
    }
}
