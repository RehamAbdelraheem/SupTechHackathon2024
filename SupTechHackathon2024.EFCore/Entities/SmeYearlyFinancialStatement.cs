using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class SmeYearlyFinancialStatement
    {
        public string CbeCustomerId { get; set; } = null!;
        public int BankId { get; set; }
        public DateTime ReportingDate { get; set; }
        public short ReportingCurrencyId { get; set; }
        public decimal TotalAssets { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal TotalEquity { get; set; }
        public decimal Profit { get; set; }
        public decimal Revenue { get; set; }

        public virtual Bank Bank { get; set; } = null!;
        public virtual CbeCustomer CbeCustomer { get; set; } = null!;
        public virtual Currency ReportingCurrency { get; set; } = null!;
    }
}
