

using SupTechHackathon2024.EFCore.DTOs;

namespace SupTechHackathon2024.Services.Interfaces
{
    public interface ICallService
    {
        Task<CallSummaryDTO> GetCallReport();

    }
}
