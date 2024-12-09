using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class Call
    {
        public long Id { get; set; }
        public string CbecustomerId { get; set; } = null!;
        public string AgentId { get; set; } = null!;
        public string AgentName { get; set; } = null!;
        public int BankId { get; set; }
        public int BranchId { get; set; }
        public string Transcript { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool? IsAianalysisFailed { get; set; }
        public string? CustomerSatisfaction { get; set; }
        public bool? IsMisSellingDetected { get; set; }
        public string? MisSellingDescription { get; set; }
        public string? RecommendedActionForBankOrRegulator { get; set; }
        public string? GuidlinesForCustomer { get; set; }
        public int? FinancialProductId { get; set; }

        public virtual Bank Bank { get; set; } = null!;
        public virtual BankBranch Branch { get; set; } = null!;
        public virtual Cbecustomer Cbecustomer { get; set; } = null!;
        public virtual FinancialService? FinancialProduct { get; set; }
    }
}
