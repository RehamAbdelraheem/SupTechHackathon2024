using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupTechHackathon2024.EFCore.Dtos
{
    public class AiYearlyReportInput
    {
        public short Year { get; set; }
        public IEnumerable<string> Categories { get; set; } = new List<string>();
        public IEnumerable<string> Products { get; set; } = new List<string>();
        public IEnumerable<CallDto> Calls { get; set; } = new List<CallDto>();

    }

    public class CallDto
    {
        public Guid Id { get; set; }
        public string CbeCustomerId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string Transcript { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string CustomerTypeName { get; set; }
        public IEnumerable<CustomerAddressDto> CustomerAddresses { get; set; }
        public IEnumerable<RiskRateHistoryDto> CustomerRiskRateYearlyHistory { get; set; }
        public IEnumerable<CreditBureauHistoryDto> CustomerCreditBureauReportingYearlyHistory { get; set; }
        public PersonDto Person { get; set; }
        public SmeDto Sme { get; set; }
        public IEnumerable<AnnualIncomeDto> LastFiveYearsAnnualIncome { get; set; }
    }
}
