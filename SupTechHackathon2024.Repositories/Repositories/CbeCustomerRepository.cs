using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using SupTechHackathon2024.EFCore;
using SupTechHackathon2024.EFCore.Dtos;
using SupTechHackathon2024.EFCore.DTOs;
using SupTechHackathon2024.EFCore.Models;
using SupTechHackathon2024.Repositories.Interfaces;
using SupTechHackathon2024.Repositories.Repositories;

namespace SupTechHackathon2024.Repositories;

public class CbeCustomerRepository : GenericRepositoryBase<CbeCustomer>, ICbeCustomerRepository
{
    public CbeCustomerRepository(CBEContext context) : base(context)
    {
    }

    public async Task<bool> AddCustomercYearFinancialReport(int bankId, short year, List<CustomerYearFinancialReportDto> CustomerYearFinancialReport)
    {

        var customerIds = CustomerYearFinancialReport.Select(fyr => fyr.CbeCustomerId).Distinct().ToHashSet();

        var customers = entities.Where(c => customerIds.Contains(c.Id)).Select(c => new { CbeCustomerId = c.Id, IsPerson = (c.PersonId != null || c.PersonId == 0) }).ToList();


        if (CustomerYearFinancialReport != null)
        {
            var personsCbeIds = customers.Where(c => c.IsPerson).Select(c => c.CbeCustomerId);

            if (CustomerYearFinancialReport.Any(c => personsCbeIds.Contains(c.CbeCustomerId)))
            {

                _context.Set<CustomerRiskRateYearlyHistory>().AddRange(CustomerYearFinancialReport.Where(c => personsCbeIds.Contains(c.CbeCustomerId)).Select(c => new CustomerRiskRateYearlyHistory
                {
                    CbeCustomerId = c.CbeCustomerId,
                    BankId = bankId,
                    Year = year,
                    Rate = c.Rate,
                }));
                _context.Set<RetailAnnualIncome>().AddRange(CustomerYearFinancialReport.Where(c => personsCbeIds.Contains(c.CbeCustomerId)).Select(c => new RetailAnnualIncome
                {
                    CbeCustomerId = c.CbeCustomerId,
                    BankId = bankId,
                    Year = year,
                    Amount = c.AnnualIncomeAmount,
                    CurrencyId = c.CurrencyId,
                }));
            }

            if (CustomerYearFinancialReport.Any(c => !personsCbeIds.Contains(c.CbeCustomerId)))
            {
                _context.Set<SmeYearlyFinancialStatement>().AddRange(CustomerYearFinancialReport.Where(c => !personsCbeIds.Contains(c.CbeCustomerId)).Select(data => new SmeYearlyFinancialStatement
                {
                    CbeCustomerId = data.CbeCustomerId,
                    BankId = bankId,
                    ReportingDate = data.ReportingDate,
                    ReportingCurrencyId = data.CurrencyId,
                    TotalAssets = data.TotalAssets,
                    TotalLiabilities = data.TotalLiabilities,
                    TotalEquity = data.TotalEquity,
                    Profit = data.Profit,
                    Revenue = data.Revenue,
                }));

            }

            await SaveChangesAsync();
            return true;
        }
        return false;
    }
}