using SupTechHackathon2024.EFCore.Dtos;
using SupTechHackathon2024.EFCore.Models;

namespace SupTechHackathon2024.Services.Interfaces
{
    public interface ICallService
    {
        Task<SingleCallDto> GetCallForAiAnalysis();
        Task<AiYearlyReportInput> GetCallsByYear(short year);

    }
}
