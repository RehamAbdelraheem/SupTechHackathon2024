using SupTechHackathon2024.EFCore.DTOs;
using SupTechHackathon2024.EFCore.Models;

namespace SupTechHackathon2024.Repositories.Interfaces
{
    public interface ICallRepository : IGenericRepository<Call>
    { 
        Task<CallSummaryDTO> GetCallReport();
    }
}


