
using SupTechHackathon2024.EFCore.DTOs;
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

        public async Task<CallSummaryDTO> GetCallReport()
        {
            return await _callRepository.GetCallReport();
        }

    }
}
