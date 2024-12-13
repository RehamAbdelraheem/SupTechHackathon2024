using Microsoft.VisualBasic;
using SupTechHackathon2024.EFCore;
using SupTechHackathon2024.EFCore.Dtos;
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

    public async Task<SingleCallDto> GetCallForAiAnalysis()
    {
        try
        {
            var result = entities
                .OrderBy(c => c.CreateDate)
                .Where(c => c.IsAiAnalysisFailed == null || c.IsAiAnalysisFailed == true)
                .Select(c => new SingleCallDto
                {
                    Id = c.Id,
                    CbeCustomerId = c.CbeCustomerId,
                    BankName = c.Bank.NameAr,
                    BranchName = c.Branch.NameAr,
                    Transcript = c.Transcript,
                    StartDateTime = c.StartTime,
                    EndDateTime = c.EndTime,
                    CustomerTypeName = c.CbeCustomer.CustomerType.NameAr,
                    Categories = _context.Set<MisSellingCategory>().Select(cat => cat.NameAr).ToList(),
                    Products = _context.Set<FinancialService>().Select(cat => cat.NameAr).ToList(),
                    CustomerAddresses = c.CbeCustomer.CustomerAddresses.Select(addr => new CustomerAddressDto
                    {
                        Country = addr.Country,
                        Governorate = addr.Governorate,
                        City = addr.City,
                        OtherDetails = addr.OtherDetails,
                        PostalCode = addr.PostalCode
                    }).ToList(),
                    CustomerCreditBureauReportingYearlyHistory = c.CbeCustomer.CustomerCreditBureauReportingYearlyHistories
                    .Where(history => history.Year > (DateTime.Now.Year - 5))
                        .OrderBy(br => br.Year)
                        .Select(risk => new CreditBureauHistoryDto
                        {
                            Score = risk.Score,
                            Year = risk.Year
                        }).ToList(),
                    CustomerRiskRateYearlyHistory = c.CbeCustomer.CustomerRiskRateYearlyHistories
                    .Where(history => history.Year > (DateTime.Now.Year - 5))
                        .OrderBy(br => br.Year)
                        .Select(rate => new RiskRateHistoryDto
                        {
                            BankName = rate.Bank.NameAr,
                            Rate = rate.Rate,
                            Year = rate.Year
                        }).ToList(),
                    //LastFiveYearsAnnualIncome = c.CbeCustomer.RetailAnnualIncomes
                    //.Where(history => history.Year > (DateTime.Now.Year - 5))
                    //    .OrderBy(br => br.Year)
                    //    .Select(income => new AnnualIncomeDto
                    //    {
                    //        BankName = income.Bank.NameAr,
                    //        Year = income.Year,
                    //        Amount = income.Amount,
                    //        CurrencyName = income.Currency.NameAr
                    //    }).ToList(),
                    Sme = new SmeDto
                    {
                        IndustrySector = c.CbeCustomer.Sme.IndustrySector,
                        YearlyFinancialStatement = c.CbeCustomer.SmeYearlyFinancialStatements
                        .Where(history => history.ReportingDate.Year > (DateTime.Now.Year - 5))
                        .Select(t => new SmeYearlyFinancialStatementDto
                        {
                            BankName = t.Bank.NameAr,
                            ReportingDate = t.ReportingDate,
                            ReportingCurrencyName = t.ReportingCurrency.NameAr,
                            TotalAssets = t.TotalAssets,
                            TotalEquity = t.TotalEquity,
                            Profit = t.Profit,
                            Revenue = t.Revenue
                        }).ToList()
                    },
                    Person = c.CbeCustomer.Person == null ? new PersonDto() : new PersonDto
                    {
                        Gender = c.CbeCustomer.Person.Gender,
                        Birthdate = c.CbeCustomer.Person.Birthdate,
                        MaritalStatusName = c.CbeCustomer.Person.MaritalStatus.NameAr,
                        EmploymentStatusName = c.CbeCustomer.Person.EmploymentStatus.NameAr,
                        EducationLevelName = c.CbeCustomer.Person.EducationLevel.NameAr,
                        Occupation = c.CbeCustomer.Person.Occupation,
                    }
                })
                .FirstOrDefault();

            return result;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task<AiYearlyReportInput> GetCallsByYear(short year)
    {
        try
        {
            var result = new AiYearlyReportInput
            {
                Year = year,
                Categories = _context.Set<MisSellingCategory>().Select(cat => cat.NameAr).ToList(),
                Products = _context.Set<FinancialService>().Select(cat => cat.NameAr).ToList(),
                Calls = entities.OrderBy(c => c.CreateDate)
                .Where(c => c.StartTime.Year == year)
                .Select(c => new CallDto
                {
                    Id = c.Id,
                    CbeCustomerId = c.CbeCustomerId,
                    BankName = c.Bank.NameAr,
                    BranchName = c.Branch.NameAr,
                    Transcript = c.Transcript,
                    StartDateTime = c.StartTime,
                    EndDateTime = c.EndTime,
                    CustomerTypeName = c.CbeCustomer.CustomerType.NameAr,
                    CustomerAddresses = c.CbeCustomer.CustomerAddresses.Select(addr => new CustomerAddressDto
                    {
                        Country = addr.Country,
                        Governorate = addr.Governorate,
                        City = addr.City,
                        OtherDetails = addr.OtherDetails,
                        PostalCode = addr.PostalCode
                    }).ToList(),
                    CustomerCreditBureauReportingYearlyHistory = c.CbeCustomer.CustomerCreditBureauReportingYearlyHistories
                    .Where(history => history.Year > (DateTime.Now.Year - 5))
                        .OrderBy(br => br.Year)
                        .Select(risk => new CreditBureauHistoryDto
                        {
                            Score = risk.Score,
                            Year = risk.Year
                        }).ToList(),
                    CustomerRiskRateYearlyHistory = c.CbeCustomer.CustomerRiskRateYearlyHistories
                    .Where(history => history.Year > (DateTime.Now.Year - 5))
                        .OrderBy(br => br.Year)
                        .Select(rate => new RiskRateHistoryDto
                        {
                            BankName = rate.Bank.NameAr,
                            Rate = rate.Rate,
                            Year = rate.Year
                        }).ToList(),
                    LastFiveYearsAnnualIncome = c.CbeCustomer.RetailAnnualIncomes
                    .Where(history => history.Year > (DateTime.Now.Year - 5))
                        .OrderBy(br => br.Year)
                        .Select(income => new AnnualIncomeDto
                        {
                            BankName = income.Bank.NameAr,
                            Year = income.Year,
                            Amount = income.Amount,
                            CurrencyName = income.Currency.NameAr
                        }).ToList(),
                    Sme = new SmeDto
                    {
                        IndustrySector = c.CbeCustomer.Sme.IndustrySector,
                        YearlyFinancialStatement = c.CbeCustomer.SmeYearlyFinancialStatements
                        .Where(history => history.ReportingDate.Year > (DateTime.Now.Year - 5))
                        .Select(t => new SmeYearlyFinancialStatementDto
                        {
                            BankName = t.Bank.NameAr,
                            ReportingDate = t.ReportingDate,
                            ReportingCurrencyName = t.ReportingCurrency.NameAr,
                            TotalAssets = t.TotalAssets,
                            TotalEquity = t.TotalEquity,
                            Profit = t.Profit,
                            Revenue = t.Revenue
                        }).ToList()
                    },
                    Person = c.CbeCustomer.Person == null ? new PersonDto() : new PersonDto
                    {
                        Gender = c.CbeCustomer.Person.Gender,
                        Birthdate = c.CbeCustomer.Person.Birthdate,
                        MaritalStatusName = c.CbeCustomer.Person.MaritalStatus.NameAr,
                        EmploymentStatusName = c.CbeCustomer.Person.EmploymentStatus.NameAr,
                        EducationLevelName = c.CbeCustomer.Person.EducationLevel.NameAr,
                        Occupation = c.CbeCustomer.Person.Occupation,
                    }
                }).ToList(),
            };

            return result;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public async Task<bool> UpdateCallAnalysis(CallAnalysisDto callAnalysis)
    {

        var result = entities.FirstOrDefault(c => c.Id == callAnalysis.Id);


        if (result != null)
        {
            if (callAnalysis.MisSellingCategory != null)
            {
                var misSellingCategory = _context.Set<MisSellingCategory>().FirstOrDefault(c => c.NameAr.ToLower() == callAnalysis.MisSellingCategory.ToLower() || c.NameEn.ToLower() == callAnalysis.MisSellingCategory.ToLower());
                result.MisSellingCategoryId = misSellingCategory?.Id;
                result.IsMisSellingDetected = callAnalysis.IsMisSellingDetected;
            }

            if (callAnalysis.ProductName != null)
            {
                var financialService = _context.Set<FinancialService>().FirstOrDefault(c => c.NameAr.ToLower() == callAnalysis.ProductName.ToLower() || c.NameEn.ToLower() == callAnalysis.ProductName.ToLower());
                result.FinancialServiceId = financialService?.Id;
            }

            result.IsAiAnalysisFailed = false;

            await _context.SaveChangesAsync();
            return true;
        }
        return true;
    }

}