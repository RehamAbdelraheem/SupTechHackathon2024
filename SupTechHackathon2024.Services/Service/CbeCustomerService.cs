
using SupTechHackathon2024.EFCore.Dtos;
using SupTechHackathon2024.EFCore.DTOs;
using SupTechHackathon2024.EFCore.Models;
using SupTechHackathon2024.Repositories.Interfaces;
using SupTechHackathon2024.Services.Interfaces;


namespace SupTechHackathon2024.Services.Service
{
    public class CbeCustomerService : ICbeCustomerService
    {
        private ICbeCustomerRepository _CbeCustomerRepository;
        public CbeCustomerService(ICbeCustomerRepository CbeCustomerRepository)
        {
            _CbeCustomerRepository = CbeCustomerRepository;
        }
        public async Task<bool> AddCustomercYearFinancialReport(int bankId, short year, List<CustomerYearFinancialReportDto> CustomerYearFinancialReport)
        {
            return await _CbeCustomerRepository.AddCustomercYearFinancialReport(bankId, year, CustomerYearFinancialReport);
        }
    }
}
