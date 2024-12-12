
using SupTechHackathon2024.EFCore.Dtos;
using SupTechHackathon2024.EFCore.Models;
using SupTechHackathon2024.Repositories.Interfaces;
using SupTechHackathon2024.Services.Interfaces;


namespace SupTechHackathon2024.Services.Service
{
    public class CallService : ICallService
    {
        private ICallRepository _callRepository;
        public CallService(ICallRepository callRepository)
        {
            _callRepository = callRepository;
        }

        public async Task<SingleCallDto> GetCallForAiAnalysis()
        {
            return await _callRepository.GetCallForAiAnalysis();
        }

        public async Task<AiYearlyReportInput> GetCallsByYear(short year)
        {
            return await _callRepository.GetCallsByYear(year);
        }

    }
}
