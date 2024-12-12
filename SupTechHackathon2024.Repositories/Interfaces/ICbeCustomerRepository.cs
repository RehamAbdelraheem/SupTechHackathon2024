using SupTechHackathon2024.EFCore.Dtos;
using SupTechHackathon2024.EFCore.DTOs;
using SupTechHackathon2024.EFCore.Models;

namespace SupTechHackathon2024.Repositories.Interfaces
{
    public interface ICbeCustomerRepository : IGenericRepository<CbeCustomer>
    {
        Task<bool> AddCustomercYearFinancialReport(int bankId, short year, List<CustomerYearFinancialReportDto> CustomerYearFinancialReport);
    }
}


