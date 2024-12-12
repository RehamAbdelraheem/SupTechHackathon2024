using SupTechHackathon2024.EFCore;
using SupTechHackathon2024.EFCore.DTOs;
using SupTechHackathon2024.EFCore.Models;
using SupTechHackathon2024.Repositories.Interfaces;
using SupTechHackathon2024.Repositories.Repositories;

namespace SupTechHackathon2024.Repositories;

public class CallRepository : GenericRepositoryBase<Call>, ICallRepository
{
    public CallRepository(CBEContext context) : base(context)
    {
    }

    public async Task<CallSummaryDTO> GetCallReport()
    {
        var result = entities.OrderBy(c => c.CreateDate).Where(c => c.IsAiAnalysisFailed == null || c.IsAiAnalysisFailed == true)
             .Select(c => new CallSummaryDTO
             {
                 Id = c.Id,
                 CbeCustomerId = c.CbeCustomerId,
                 BankName = c.Bank.NameAr,
                 BranchName = c.Branch.NameAr,
                 Transcript = c.Transcript,
                 StartDateTime = c.StartTime,
                 EndDateTime = c.EndTime,
                 CustomerTypeName = c.CbeCustomer.CustomerType.NameAr,
                 Categories = _context.Set<MisSellingCategory>().Select(cat => cat.NameAr),
                 CustomerAddresses = c.CbeCustomer.CustomerAddresses.Select(addr => new CustomerAddressDTO
                 {
                     Country = addr.Country,
                     Governorate = addr.Governorate,
                     City = addr.City,
                     OtherDetails = addr.OtherDetails,
                     PostalCode = addr.PostalCode
                 }),
                 CustomerCreditBureauReportingYearlyHistory = c.CbeCustomer.CustomerCreditBureauReportingYearlyHistories
                 .OrderBy(br => br.Year).DistinctBy(c => c.Year).Take(5)
                 .Select(risk => new CreditBureauHistoryDTO
                 {
                     Score = risk.Score,
                     Year = risk.Year
                 }),

                 CustomerRiskRateYearlyHistory = c.CbeCustomer.CustomerRiskRateYearlyHistories
                 .OrderBy(br => br.Year).DistinctBy(c => c.Year).Take(5)
                 .Select(credit => new RiskRateHistoryDTO
                 {
                     BankName = c.Bank.NameAr,
                     Rate = credit.Rate,
                     Year = credit.Year
                 }),
                 LastFiveYearsAnnualIncome = c.CbeCustomer.RetailAnnualIncomes
                  .OrderBy(br => br.Year).DistinctBy(c=>c.Year).Take(5)
                 .Select(income => new AnnualIncomeDTO
                 {
                     BankName = income.Bank.NameAr,
                     Year = income.Year,
                     Amount = income.Amount,
                     CurrencyName = income.Currency.NameAr
                 }),
                 Sme = new SmeDTO
                 {
                     IndustrySector = c.CbeCustomer.Sme.IndustrySector,
                     YearlyFinancialStatement = c.CbeCustomer.SmeYearlyFinancialStatements.Select(t => new SmeYearlyFinancialStatementDTO
                     {
                         BankName = t.Bank.NameAr,
                         ReportingDate = t.ReportingDate,
                         ReportingCurrencyName = t.ReportingCurrency.NameAr,
                         TotalAssets = t.TotalAssets,
                         TotalEquity = t.TotalEquity,
                         Profit = t.Profit,
                         Revenue = t.Revenue

                     }) 
                 }
                 ,
                 Person = c.CbeCustomer.Person == null ? new PersonDTO() : new PersonDTO
                 {
                     Gender = c.CbeCustomer.Person.Gender,
                     Birthdate = c.CbeCustomer.Person.Birthdate,
                     MaritalStatusName = c.CbeCustomer.Person.MaritalStatus.NameAr,
                     EmploymentStatusName = c.CbeCustomer.Person.EmploymentStatus.NameAr,
                     EducationLevelName = c.CbeCustomer.Person.EducationLevel.NameAr,
                     Occupation = c.CbeCustomer.Person.Occupation,
                 } ,

             }).FirstOrDefault();

        return result;
    }


}