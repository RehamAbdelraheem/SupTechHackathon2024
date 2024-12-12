using SupTechHackathon2024.EFCore.Dtos;
using SupTechHackathon2024.EFCore.DTOs;
using SupTechHackathon2024.EFCore.Models;

namespace SupTechHackathon2024.Repositories.Interfaces
{
    public interface ICallRepository : IGenericRepository<Call>
    { 
        Task<SingleCallDto> GetCallForAiAnalysis();
        Task<AiYearlyReportInput> GetCallsByYear(short year);
        Task<bool> UpdateCallAnalysis(CallAnalysisDto callAnalysis);
    }
}


