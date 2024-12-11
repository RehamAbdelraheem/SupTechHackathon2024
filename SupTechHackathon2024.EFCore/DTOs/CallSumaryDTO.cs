
namespace SupTechHackathon2024.EFCore.DTOs
{
    public class CallSumaryDTO
    {
        public long Id { get; set; }
        public string CbeCustomerId { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string Transcript { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string CustomerTypeName { get; set; }
        public IEnumerable<CustomerAddressDTO> CustomerAddresses { get; set; }
        public IEnumerable<RiskRateHistoryDTO> CustomerRiskRateYearlyHistory { get; set; }
        public IEnumerable<CreditBureauHistoryDTO> CustomerCreditBureauReportingYearlyHistory { get; set; }
        public PersonDTO Person { get; set; }
        public SmeDTO Sme { get; set; }
        public IEnumerable<AnnualIncomeDTO> LastFiveYearsAnnualIncome { get; set; }
    }

    public class CustomerAddressDTO
    {
        public string Country { get; set; }
        public string Governorate { get; set; }
        public string City { get; set; }
        public string OtherDetails { get; set; }
        public string PostalCode { get; set; }
    }

    public class RiskRateHistoryDTO
    {
        public string BankName { get; set; }
        public int Rate { get; set; }
        public int Year { get; set; }
    }

    public class CreditBureauHistoryDTO
    {
        public int Score { get; set; }
        public int Year { get; set; }
    }

    public class PersonDTO
    {
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string MaritalStatusName { get; set; }
        public string EmploymentStatusName { get; set; }
        public string EducationLevelName { get; set; }
        public string Occupation { get; set; }

    }

    public class AnnualIncomeDTO
    {
        public string BankName { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyName { get; set; }
    }
    public class SmeDTO
    {
        public string IndustrySector { get; set; }
        public IEnumerable<SmeYearlyFinancialStatementDTO> YearlyFinancialStatement { get; set; }
    }

    public class SmeYearlyFinancialStatementDTO
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
